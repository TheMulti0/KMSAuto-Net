﻿// Decompiled with JetBrains decompiler
// Type: KMSAuto_Net.Utilities
// Assembly: KMSAuto Net, Version=1.3.9.0, Culture=neutral, PublicKeyToken=334b8937f48b3142
// MVID: 4B7D3064-FB93-447A-8F9C-DC4A190A5ACC
// Assembly location: D:\Desktop\KMSAuto Net-cleaned-cleaned.exe

using KMSAuto_Net.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace KMSAuto_Net
{
  [DesignerGenerated]
  public class Utilities : Form
  {
    private IContainer components;
    private string NotDisk;

    public Utilities()
    {
      this.Load += new EventHandler(this.Utilities_Load);
      this.NotDisk = "===";
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Utilities));
      this.GroupBox14 = new GroupBox();
      this.ComboBoxDisk = new ComboBox();
      this.Button3 = new Button();
      this.Button45 = new Button();
      this.Button44 = new Button();
      this.GroupBox20 = new GroupBox();
      this.Button38 = new Button();
      this.ToolTip1 = new ToolTip(this.components);
      this.GroupBox1 = new GroupBox();
      this.Label1 = new Label();
      this.Button2 = new Button();
      this.Button1 = new Button();
      this.GroupBox14.SuspendLayout();
      this.GroupBox20.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      this.GroupBox14.Controls.Add((Control) this.ComboBoxDisk);
      this.GroupBox14.Controls.Add((Control) this.Button3);
      this.GroupBox14.Controls.Add((Control) this.Button45);
      this.GroupBox14.Controls.Add((Control) this.Button44);
      this.GroupBox14.Location = new Point(56, 21);
      this.GroupBox14.Margin = new Padding(4);
      this.GroupBox14.Name = "GroupBox14";
      this.GroupBox14.Padding = new Padding(4);
      this.GroupBox14.Size = new Size(440, 110);
      this.GroupBox14.TabIndex = 4;
      this.GroupBox14.TabStop = false;
      this.GroupBox14.Text = "GroupBox14";
      this.ComboBoxDisk.DropDownStyle = ComboBoxStyle.DropDownList;
      this.ComboBoxDisk.FormattingEnabled = true;
      this.ComboBoxDisk.Location = new Point(346, 62);
      this.ComboBoxDisk.Name = "ComboBoxDisk";
      this.ComboBoxDisk.Size = new Size(72, 24);
      this.ComboBoxDisk.TabIndex = 3;
      this.Button3.Location = new Point(20, 60);
      this.Button3.Margin = new Padding(4);
      this.Button3.Name = "Button3";
      this.Button3.Size = new Size(318, 28);
      this.Button3.TabIndex = 2;
      this.Button3.Text = "Button3";
      this.Button3.UseVisualStyleBackColor = true;
      this.Button45.Location = new Point(20, 20);
      this.Button45.Margin = new Padding(4);
      this.Button45.Name = "Button45";
      this.Button45.Size = new Size(187, 28);
      this.Button45.TabIndex = 1;
      this.Button45.Text = "Button45";
      this.Button45.UseVisualStyleBackColor = true;
      this.Button44.Location = new Point(233, 20);
      this.Button44.Margin = new Padding(4);
      this.Button44.Name = "Button44";
      this.Button44.Size = new Size(187, 28);
      this.Button44.TabIndex = 0;
      this.Button44.Text = "Button44";
      this.Button44.UseVisualStyleBackColor = true;
      this.GroupBox20.Controls.Add((Control) this.Button38);
      this.GroupBox20.Location = new Point(56, 139);
      this.GroupBox20.Margin = new Padding(4);
      this.GroupBox20.Name = "GroupBox20";
      this.GroupBox20.Padding = new Padding(4);
      this.GroupBox20.Size = new Size(440, 58);
      this.GroupBox20.TabIndex = 7;
      this.GroupBox20.TabStop = false;
      this.GroupBox20.Text = "GroupBox20";
      this.Button38.Location = new Point(19, 20);
      this.Button38.Margin = new Padding(4);
      this.Button38.Name = "Button38";
      this.Button38.Size = new Size(400, 28);
      this.Button38.TabIndex = 0;
      this.Button38.Text = "Button38";
      this.Button38.UseVisualStyleBackColor = true;
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.Button2);
      this.GroupBox1.Controls.Add((Control) this.Button1);
      this.GroupBox1.Location = new Point(56, 205);
      this.GroupBox1.Margin = new Padding(4);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Padding = new Padding(4);
      this.GroupBox1.Size = new Size(440, 129);
      this.GroupBox1.TabIndex = 8;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "GroupBox1";
      this.Label1.AutoSize = true;
      this.Label1.ForeColor = Color.Red;
      this.Label1.Location = new Point(19, 55);
      this.Label1.Margin = new Padding(4, 0, 4, 0);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(51, 17);
      this.Label1.TabIndex = 2;
      this.Label1.Text = "Label1";
      this.Button2.Location = new Point(235, 18);
      this.Button2.Margin = new Padding(4);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(185, 28);
      this.Button2.TabIndex = 1;
      this.Button2.Text = "Button2";
      this.Button2.UseVisualStyleBackColor = true;
      this.Button1.Location = new Point(19, 18);
      this.Button1.Margin = new Padding(4);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(187, 28);
      this.Button1.TabIndex = 0;
      this.Button1.Text = "Button1";
      this.Button1.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(552, 402);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.GroupBox20);
      this.Controls.Add((Control) this.GroupBox14);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      this.Name = nameof (Utilities);
      this.StartPosition = FormStartPosition.Manual;
      this.Text = nameof (Utilities);
      this.GroupBox14.ResumeLayout(false);
      this.GroupBox20.ResumeLayout(false);
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual GroupBox GroupBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button45
    {
      get
      {
        return this._Button45;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button45_Click);
        Button button45_1 = this._Button45;
        if (button45_1 != null)
          button45_1.Click -= eventHandler;
        this._Button45 = value;
        Button button45_2 = this._Button45;
        if (button45_2 == null)
          return;
        button45_2.Click += eventHandler;
      }
    }

    internal virtual Button Button44
    {
      get
      {
        return this._Button44;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button44_Click);
        Button button44_1 = this._Button44;
        if (button44_1 != null)
          button44_1.Click -= eventHandler;
        this._Button44 = value;
        Button button44_2 = this._Button44;
        if (button44_2 == null)
          return;
        button44_2.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button38
    {
      get
      {
        return this._Button38;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button38_Click);
        Button button38_1 = this._Button38;
        if (button38_1 != null)
          button38_1.Click -= eventHandler;
        this._Button38 = value;
        Button button38_2 = this._Button38;
        if (button38_2 == null)
          return;
        button38_2.Click += eventHandler;
      }
    }

    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button2
    {
      get
      {
        return this._Button2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        Button button2_1 = this._Button2;
        if (button2_1 != null)
          button2_1.Click -= eventHandler;
        this._Button2 = value;
        Button button2_2 = this._Button2;
        if (button2_2 == null)
          return;
        button2_2.Click += eventHandler;
      }
    }

    internal virtual Button Button1
    {
      get
      {
        return this._Button1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        Button button1_1 = this._Button1;
        if (button1_1 != null)
          button1_1.Click -= eventHandler;
        this._Button1 = value;
        Button button1_2 = this._Button1;
        if (button1_2 == null)
          return;
        button1_2.Click += eventHandler;
      }
    }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox ComboBoxDisk
    {
      get
      {
        return this._ComboBoxDisk;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ComboBoxDisk_SelectedIndexChanged);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.ComboBoxDisk_MouseLeave);
        ComboBox comboBoxDisk1 = this._ComboBoxDisk;
        if (comboBoxDisk1 != null)
        {
          comboBoxDisk1.SelectedIndexChanged -= eventHandler;
          comboBoxDisk1.MouseDown -= mouseEventHandler;
        }
        this._ComboBoxDisk = value;
        ComboBox comboBoxDisk2 = this._ComboBoxDisk;
        if (comboBoxDisk2 == null)
          return;
        comboBoxDisk2.SelectedIndexChanged += eventHandler;
        comboBoxDisk2.MouseDown += mouseEventHandler;
      }
    }

    internal virtual Button Button3
    {
      get
      {
        return this._Button3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        Button button3_1 = this._Button3;
        if (button3_1 != null)
          button3_1.Click -= eventHandler;
        this._Button3 = value;
        Button button3_2 = this._Button3;
        if (button3_2 == null)
          return;
        button3_2.Click += eventHandler;
      }
    }

    private void Utilities_Load(object sender, EventArgs e)
    {
      this.Text = Lang.UtilitiesTxt;
      this.Label1.Text = Lang.UtilitiesLbl1Txt;
      this.Button1.Text = Lang.UtilitiesBtn1Txt;
      this.Button2.Text = Lang.UtilitiesBtn2Txt;
      this.Button44.Text = Lang.ButtonText31;
      this.Button45.Text = Lang.ScanNowLog;
      this.GroupBox1.Text = Lang.UtilitiesGrBox1Txt;
      this.GroupBox14.Text = Lang.ScanNow;
      this.ToolTip1.SetToolTip((Control) this.Button44, Lang.ToolTipButton44);
      this.Button38.Text = "KMS-Service Client by Hotbird64";
      this.GroupBox20.Text = Lang.GetHwidKmstxt;
      this.Button3.Text = Lang.Repairtxt;
      this.GetDisks();
      if (Operators.CompareString(this.ComboBoxDisk.Text, this.NotDisk, false) == 0)
        this.Button3.Enabled = false;
      this.ToolTip1.SetToolTip((Control) this.ComboBoxDisk, Lang.ToolTipComboBoxDisk);
    }

    private void GetDisks()
    {
      this.ComboBoxDisk.Items.Clear();
      this.ComboBoxDisk.Items.Add((object) this.NotDisk);
      DriveInfo[] drives = DriveInfo.GetDrives();
      int index = 0;
      while (index < drives.Length)
      {
        DriveInfo driveInfo = drives[index];
        if (driveInfo.DriveType == DriveType.Removable | driveInfo.DriveType == DriveType.CDRom)
          this.ComboBoxDisk.Items.Add((object) driveInfo.Name);
        checked { ++index; }
      }
      this.ComboBoxDisk.Text = this.NotDisk;
    }

    private void Button38_Click(object sender, EventArgs e)
    {
      MyProject.Forms.GetHwidKms.Top = checked (this.Top + 80);
      MyProject.Forms.GetHwidKms.Left = checked (this.Left + 20);
      int num = (int) MyProject.Forms.GetHwidKms.ShowDialog();
      MyProject.Forms.GetHwidKms.Refresh();
    }

    private void Button45_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Form1.MyAudioClick();
      if (!File.Exists(MyProject.Forms.Form1.Windir + "\\Logs\\CBS\\CBS.log"))
        return;
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /c findstr /c:\"[SR]\" " + MyProject.Forms.Form1.Windir + "\\Logs\\CBS\\CBS.log >\"" + MyProject.Forms.Form1.Tempdir + "\"\\sfcdetails.txt", AppWinStyle.Hide, true, -1);
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "notepad.exe " + MyProject.Forms.Form1.Tempdir + "\\sfcdetails.txt", AppWinStyle.NormalFocus, false, -1);
    }

    private void Button44_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Form1.MyAudioClick();
      Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /k color 1E && prompt $G && Title                  && mode con cols=80 lines=20 && sfc.exe /scannow", AppWinStyle.NormalFocus, false, -1);
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Form1.MyAudioClick();
      string text = this.Button1.Text;
      this.Button1.Text = Lang.ButtonRuns;
      this.Button1.Refresh();
      int num = checked (MyProject.Forms.Form1.TaskList.Length - 1);
      int index = 0;
      while (index <= num)
      {
        Interaction.Shell(MyProject.Forms.Form1.SysPath + "SCHTASKS /Change /TN \"" + MyProject.Forms.Form1.TaskList[index] + "\" /DISABLE", AppWinStyle.Hide, false, -1);
        checked { ++index; }
      }
      Thread.Sleep(1000);
      this.Button1.Text = text;
      this.Button1.Refresh();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Form1.MyAudioClick();
      string text = this.Button2.Text;
      this.Button2.Text = Lang.ButtonRuns;
      this.Button2.Refresh();
      int num = checked (MyProject.Forms.Form1.TaskList.Length - 1);
      int index = 0;
      while (index <= num)
      {
        Interaction.Shell(MyProject.Forms.Form1.SysPath + "SCHTASKS /Change /TN \"" + MyProject.Forms.Form1.TaskList[index] + "\" /ENABLE", AppWinStyle.Hide, false, -1);
        checked { ++index; }
      }
      Thread.Sleep(1000);
      this.Button2.Text = text;
      this.Button2.Refresh();
    }

    private void ComboBoxDisk_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.ComboBoxDisk.Text, this.NotDisk, false) == 0)
        this.Button3.Enabled = false;
      else if (File.Exists(this.ComboBoxDisk.Text + "Sources\\Install.wim"))
        this.Button3.Enabled = true;
      else
        this.ComboBoxDisk.Text = this.NotDisk;
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Form1.MyAudioClick();
      if (File.Exists(this.ComboBoxDisk.Text + "Sources\\Install.wim"))
        Interaction.Shell(MyProject.Forms.Form1.SysPath + "cmd.exe /k color 1E && prompt $G && Title                  && mode con cols=80 lines=20 && DISM /Online /Cleanup-Image /RestoreHealth /source:WIM:" + this.ComboBoxDisk.Text + "Sources\\Install.wim:1 /LimitAccess", AppWinStyle.NormalFocus, false, -1);
      else
        this.GetDisks();
    }

    private void ComboBoxDisk_MouseLeave(object sender, EventArgs e)
    {
      this.GetDisks();
    }
  }
}