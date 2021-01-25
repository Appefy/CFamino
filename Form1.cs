// Decompiled with JetBrains decompiler
// Type: CFiamino.Form1
// Assembly: CFiamino, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 49C54466-40E5-4320-9963-202A20ED3FDE
// Assembly location: C:\Users\Prithwiraj Samanta\Documents\CFamino.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CFiamino
{
  public class Form1 : Form
  {
    private string curpath = "";
    private string curfile = "";
    private Stack stack = new Stack();
    private Stack Stack1 = new Stack();
    private IContainer components = (IContainer) null;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private Button button2;
    private Button button3;
    private Button button4;
    private ToolStripMenuItem newToolStripMenuItem;
    private ToolStripMenuItem cFileToolStripMenuItem;
    private ToolStripMenuItem cFileToolStripMenuItem1;
    private ToolStripMenuItem openToolStripMenuItem;
    private Button button1;
    private Button button5;
    private GroupBox groupBox1;
    private Button SAVE;
    private GroupBox groupBox2;
    private TextBox textBox3;
    private GroupBox groupBox3;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private SaveFileDialog saveFileDialog1;
    private OpenFileDialog openFileDialog1;
    private SaveFileDialog saveFileDialog3;
    private SaveFileDialog saveFileDialog4;
    private GroupBox groupBox6;
    private TextBox textBox2;
    private Button button8;
    private Button button7;
    private Button button6;
    private GroupBox groupBox4;
    private TextBox textBox1;

    public Form1()
    {
      this.InitializeComponent();
      this.textBox1.ScrollBars = ScrollBars.Both;
      this.textBox2.ScrollBars = ScrollBars.Both;
      this.textBox3.ScrollBars = ScrollBars.Both;
    }

    private void button1_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      if ((uint) this.stack.Count <= 0U)
        return;
      this.textBox1.Text = this.stack.Pop().ToString();
      this.Stack1.Push((object) this.textBox1.Text);
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.saveFileDialog1.Title = "Savs As";
      this.saveFileDialog1.AddExtension = true;
      this.saveFileDialog1.CheckPathExists = true;
      this.saveFileDialog1.Filter = "cpp(*.cpp)|*.cpp|c(*.c)|*.c";
      int num = (int) this.saveFileDialog1.ShowDialog();
    }

    private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
      StreamWriter streamWriter = new StreamWriter(this.saveFileDialog1.FileName);
      streamWriter.WriteLine(this.textBox1.Text);
      streamWriter.Flush();
      streamWriter.Close();
      streamWriter.Dispose();
      string fileName = this.saveFileDialog1.FileName;
      this.groupBox4.Text = fileName.Substring(fileName.LastIndexOf('\\')).TrimStart('\\');
      this.curpath = this.saveFileDialog1.FileName;
      this.curfile = fileName.Substring(fileName.LastIndexOf('\\')).TrimStart('\\');
      this.saveFileDialog1.Dispose();
    }

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
      StreamReader streamReader = new StreamReader(this.openFileDialog1.FileName);
      string str1 = "";
      string str2;
      while ((str2 = streamReader.ReadLine()) != null)
        str1 = str1 + Environment.NewLine + str2;
      this.textBox1.Text = str1;
      string fileName = this.openFileDialog1.FileName;
      this.groupBox4.Text = fileName.Substring(fileName.LastIndexOf('\\')).TrimStart('\\');
      this.curpath = this.openFileDialog1.FileName;
      this.curfile = fileName.Substring(fileName.LastIndexOf('\\')).TrimStart('\\');
      streamReader.Close();
      streamReader.Dispose();
      this.openFileDialog1.Dispose();
    }

    private void cFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.saveFileDialog3.AutoUpgradeEnabled = true;
      this.saveFileDialog3.Title = "Create a new C File";
      this.saveFileDialog3.DefaultExt = ".c";
      int num = (int) this.saveFileDialog3.ShowDialog();
    }

    private void saveFileDialog3_FileOk(object sender, CancelEventArgs e)
    {
      File.Create(this.saveFileDialog3.FileName).Close();
      string fileName = this.saveFileDialog3.FileName;
      this.groupBox4.Text = fileName.Substring(fileName.LastIndexOf('\\')).TrimStart('\\');
      this.curpath = this.saveFileDialog3.FileName;
      this.curfile = fileName.Substring(fileName.LastIndexOf('\\')).TrimStart('\\');
      this.saveFileDialog3.Dispose();
      this.textBox1.Text = "";
    }

    private void cFileToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.saveFileDialog4.AutoUpgradeEnabled = true;
      this.saveFileDialog4.Title = "Create a new C++ File";
      this.saveFileDialog4.DefaultExt = ".cpp";
      int num = (int) this.saveFileDialog4.ShowDialog();
    }

    private void saveFileDialog4_FileOk(object sender, CancelEventArgs e)
    {
      File.Create(this.saveFileDialog4.FileName).Close();
      string fileName = this.saveFileDialog4.FileName;
      this.groupBox4.Text = fileName.Substring(fileName.LastIndexOf('\\')).TrimStart('\\');
      this.curpath = this.saveFileDialog4.FileName;
      this.curfile = fileName.Substring(fileName.LastIndexOf('\\')).TrimStart('\\');
      this.saveFileDialog4.Dispose();
      this.textBox1.Text = "";
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Process process = new Process();
      process.StartInfo.FileName = this.curpath.Substring(0, this.curpath.LastIndexOf('\\')) + "\\" + this.curfile.Substring(0, this.curfile.LastIndexOf('.')) + ".exe";
      process.StartInfo.Arguments = "";
      process.StartInfo.RedirectStandardInput = true;
      process.StartInfo.RedirectStandardOutput = true;
      process.StartInfo.RedirectStandardError = true;
      process.StartInfo.UseShellExecute = false;
      process.Start();
      StreamReader standardOutput = process.StandardOutput;
      StreamWriter standardInput = process.StandardInput;
      StreamReader standardError = process.StandardError;
      string str1 = "";
      string str2 = "";
      standardInput.WriteLine(this.textBox2.Text);
      standardInput.Flush();
      standardInput.Close();
      string str3;
      while ((str3 = standardOutput.ReadLine()) != null)
        str2 = str2 + Environment.NewLine + str3;
      this.textBox3.Text = "STDOUT:" + Environment.NewLine + str2;
      standardOutput.Close();
      string str4;
      while ((str4 = standardError.ReadLine()) != null)
        str1 = str1 + Environment.NewLine + str4;
      if (str1 != "")
      {
        this.textBox3.Text = Environment.NewLine;
        this.textBox3.Text = this.textBox3.Text + Environment.NewLine + "STDERR:" + Environment.NewLine + str1;
      }
      standardError.Close();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      Process process = new Process();
      process.StartInfo.FileName = "cmd.exe";
      process.StartInfo.Arguments = "";
      process.StartInfo.RedirectStandardInput = true;
      process.StartInfo.RedirectStandardOutput = true;
      process.StartInfo.RedirectStandardError = true;
      process.StartInfo.UseShellExecute = false;
      process.Start();
      StreamReader standardOutput = process.StandardOutput;
      StreamWriter standardInput = process.StandardInput;
      StreamReader standardError = process.StandardError;
      string str1 = "";
      string str2 = "";
      standardInput.WriteLine("cd C:\\MinGW\\bin");
      string str3 = !(this.curfile.Substring(this.curfile.LastIndexOf('.')) == ".cpp") ? "gcc -w " : "g++ -w ";
      standardInput.WriteLine(str3 + this.curpath + " -o " + this.curpath.Substring(0, this.curpath.LastIndexOf('\\')) + "\\" + this.curfile.Substring(0, this.curfile.LastIndexOf('.')));
      standardInput.Flush();
      standardInput.Close();
      string str4;
      while ((str4 = standardOutput.ReadLine()) != null)
        str2 = str2 + Environment.NewLine + str4;
      this.textBox3.Text = "STDOUT:" + Environment.NewLine + str2;
      standardOutput.Close();
      string str5;
      while ((str5 = standardError.ReadLine()) != null)
        str1 = str1 + Environment.NewLine + str5;
      if (str1 != "")
      {
        this.textBox3.Text = Environment.NewLine;
        this.textBox3.Text = this.textBox3.Text + Environment.NewLine + "STDERR:" + Environment.NewLine + str1;
      }
      standardError.Close();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Process process1 = new Process();
      process1.StartInfo.FileName = "cmd.exe";
      process1.StartInfo.Arguments = "";
      process1.StartInfo.RedirectStandardInput = true;
      process1.StartInfo.RedirectStandardOutput = true;
      process1.StartInfo.RedirectStandardError = true;
      process1.StartInfo.UseShellExecute = false;
      process1.Start();
      StreamReader standardOutput1 = process1.StandardOutput;
      StreamWriter standardInput1 = process1.StandardInput;
      StreamReader standardError1 = process1.StandardError;
      string str1 = "";
      string str2 = "";
      standardInput1.WriteLine("cd C:\\MinGW\\bin");
      string str3 = !(this.curfile.Substring(this.curfile.LastIndexOf('.')) == ".cpp") ? "gcc -w " : "g++ -w ";
      standardInput1.WriteLine(str3 + this.curpath + " -o " + this.curpath.Substring(0, this.curpath.LastIndexOf('\\')) + "\\" + this.curfile.Substring(0, this.curfile.LastIndexOf('.')));
      standardInput1.Flush();
      standardInput1.Close();
      string str4;
      while ((str4 = standardOutput1.ReadLine()) != null)
        str2 = str2 + Environment.NewLine + str4;
      this.textBox3.Text = "STDOUT:" + Environment.NewLine + str2;
      standardOutput1.Close();
      string str5;
      while ((str5 = standardError1.ReadLine()) != null)
        str1 = str1 + Environment.NewLine + str5;
      this.textBox3.Text = this.textBox3.Text + Environment.NewLine + "STDERR:" + Environment.NewLine + str1;
      standardError1.Close();
      if (!(str1 == ""))
        return;
      Process process2 = new Process();
      process2.StartInfo.FileName = this.curpath.Substring(0, this.curpath.LastIndexOf('\\')) + "\\" + this.curfile.Substring(0, this.curfile.LastIndexOf('.')) + ".exe";
      process2.StartInfo.Arguments = "";
      process2.StartInfo.RedirectStandardInput = true;
      process2.StartInfo.RedirectStandardOutput = true;
      process2.StartInfo.RedirectStandardError = true;
      process2.StartInfo.UseShellExecute = false;
      process2.Start();
      StreamReader standardOutput2 = process2.StandardOutput;
      StreamWriter standardInput2 = process2.StandardInput;
      StreamReader standardError2 = process2.StandardError;
      string str6 = "";
      string str7 = "";
      standardInput2.WriteLine(this.textBox2.Text);
      standardInput2.Flush();
      standardInput2.Close();
      string str8;
      while ((str8 = standardOutput2.ReadLine()) != null)
        str7 = str7 + Environment.NewLine + str8;
      this.textBox3.Text = "STDOUT:" + Environment.NewLine + str7;
      standardOutput2.Close();
      string str9;
      while ((str9 = standardError2.ReadLine()) != null)
        str6 = str6 + Environment.NewLine + str9;
      if (str6 != "")
      {
        this.textBox3.Text = Environment.NewLine;
        this.textBox3.Text = this.textBox3.Text + Environment.NewLine + "STDERR:" + Environment.NewLine + str6;
      }
      standardError2.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if ((uint) this.Stack1.Count <= 0U)
        return;
      this.textBox1.Text = this.Stack1.Pop().ToString();
    }

    private void SAVE_Click(object sender, EventArgs e)
    {
      StreamWriter streamWriter = new StreamWriter(this.curpath);
      streamWriter.WriteLine(this.textBox1.Text);
      streamWriter.Flush();
      streamWriter.Close();
      streamWriter.Dispose();
      this.saveFileDialog1.Dispose();
    }

    private void groupBox6_Enter(object sender, EventArgs e)
    {
    }

    private void textBox1_TextChanged(object sender, EventArgs e) => this.stack.Push((object) this.textBox1.Text);

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.openFileDialog1.CheckFileExists = true;
      this.openFileDialog1.AutoUpgradeEnabled = true;
      this.openFileDialog1.Title = "Open File";
      int num = (int) this.openFileDialog1.ShowDialog();
    }

    private void button6_Click(object sender, EventArgs e) => this.textBox1.Cut();

    private void button8_Click(object sender, EventArgs e) => this.textBox1.Paste();

    private void button7_Click(object sender, EventArgs e) => this.textBox1.Copy();

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {
    }

    private void groupBox4_Enter(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.menuStrip1 = new MenuStrip();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.newToolStripMenuItem = new ToolStripMenuItem();
      this.cFileToolStripMenuItem = new ToolStripMenuItem();
      this.cFileToolStripMenuItem1 = new ToolStripMenuItem();
      this.openToolStripMenuItem = new ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new ToolStripMenuItem();
      this.button2 = new Button();
      this.button3 = new Button();
      this.button4 = new Button();
      this.button1 = new Button();
      this.button5 = new Button();
      this.groupBox1 = new GroupBox();
      this.button8 = new Button();
      this.button7 = new Button();
      this.button6 = new Button();
      this.SAVE = new Button();
      this.groupBox2 = new GroupBox();
      this.textBox3 = new TextBox();
      this.groupBox3 = new GroupBox();
      this.saveFileDialog1 = new SaveFileDialog();
      this.openFileDialog1 = new OpenFileDialog();
      this.saveFileDialog3 = new SaveFileDialog();
      this.saveFileDialog4 = new SaveFileDialog();
      this.groupBox6 = new GroupBox();
      this.textBox2 = new TextBox();
      this.groupBox4 = new GroupBox();
      this.textBox1 = new TextBox();
      this.menuStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      this.menuStrip1.BackColor = Color.ForestGreen;
      componentResourceManager.ApplyResources((object) this.menuStrip1, "menuStrip1");
      this.menuStrip1.ImageScalingSize = new Size(24, 24);
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.fileToolStripMenuItem
      });
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
      this.fileToolStripMenuItem.BackColor = Color.ForestGreen;
      this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.newToolStripMenuItem,
        (ToolStripItem) this.openToolStripMenuItem,
        (ToolStripItem) this.saveAsToolStripMenuItem
      });
      componentResourceManager.ApplyResources((object) this.fileToolStripMenuItem, "fileToolStripMenuItem");
      this.fileToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.newToolStripMenuItem.BackColor = Color.ForestGreen;
      this.newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.cFileToolStripMenuItem,
        (ToolStripItem) this.cFileToolStripMenuItem1
      });
      this.newToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      componentResourceManager.ApplyResources((object) this.newToolStripMenuItem, "newToolStripMenuItem");
      this.cFileToolStripMenuItem.BackColor = Color.ForestGreen;
      this.cFileToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
      this.cFileToolStripMenuItem.Name = "cFileToolStripMenuItem";
      componentResourceManager.ApplyResources((object) this.cFileToolStripMenuItem, "cFileToolStripMenuItem");
      this.cFileToolStripMenuItem.Click += new EventHandler(this.cFileToolStripMenuItem_Click);
      this.cFileToolStripMenuItem1.BackColor = Color.ForestGreen;
      this.cFileToolStripMenuItem1.ForeColor = SystemColors.ButtonHighlight;
      this.cFileToolStripMenuItem1.Name = "cFileToolStripMenuItem1";
      componentResourceManager.ApplyResources((object) this.cFileToolStripMenuItem1, "cFileToolStripMenuItem1");
      this.cFileToolStripMenuItem1.Click += new EventHandler(this.cFileToolStripMenuItem1_Click);
      this.openToolStripMenuItem.BackColor = Color.ForestGreen;
      this.openToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      componentResourceManager.ApplyResources((object) this.openToolStripMenuItem, "openToolStripMenuItem");
      this.openToolStripMenuItem.Click += new EventHandler(this.openToolStripMenuItem_Click);
      this.saveAsToolStripMenuItem.BackColor = Color.ForestGreen;
      this.saveAsToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      componentResourceManager.ApplyResources((object) this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
      this.saveAsToolStripMenuItem.Click += new EventHandler(this.saveAsToolStripMenuItem_Click);
      this.button2.BackColor = Color.ForestGreen;
      this.button2.ForeColor = SystemColors.ButtonHighlight;
      componentResourceManager.ApplyResources((object) this.button2, "button2");
      this.button2.Name = "button2";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.BackColor = Color.ForestGreen;
      this.button3.ForeColor = SystemColors.ButtonHighlight;
      componentResourceManager.ApplyResources((object) this.button3, "button3");
      this.button3.Name = "button3";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.BackColor = Color.ForestGreen;
      this.button4.ForeColor = SystemColors.ButtonHighlight;
      componentResourceManager.ApplyResources((object) this.button4, "button4");
      this.button4.Name = "button4";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button1.BackColor = Color.ForestGreen;
      this.button1.ForeColor = SystemColors.ButtonHighlight;
      componentResourceManager.ApplyResources((object) this.button1, "button1");
      this.button1.Name = "button1";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click_1);
      this.button5.BackColor = Color.ForestGreen;
      this.button5.ForeColor = SystemColors.ButtonHighlight;
      componentResourceManager.ApplyResources((object) this.button5, "button5");
      this.button5.Name = "button5";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.groupBox1.BackColor = Color.ForestGreen;
      this.groupBox1.Controls.Add((Control) this.button8);
      this.groupBox1.Controls.Add((Control) this.button7);
      this.groupBox1.Controls.Add((Control) this.button6);
      this.groupBox1.Controls.Add((Control) this.SAVE);
      this.groupBox1.Controls.Add((Control) this.button1);
      this.groupBox1.Controls.Add((Control) this.button2);
      componentResourceManager.ApplyResources((object) this.groupBox1, "groupBox1");
      this.groupBox1.ForeColor = SystemColors.ButtonHighlight;
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.TabStop = false;
      this.groupBox1.Enter += new EventHandler(this.groupBox1_Enter);
      this.button8.BackColor = Color.ForestGreen;
      this.button8.ForeColor = SystemColors.ButtonHighlight;
      componentResourceManager.ApplyResources((object) this.button8, "button8");
      this.button8.Name = "button8";
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.button7.BackColor = Color.ForestGreen;
      componentResourceManager.ApplyResources((object) this.button7, "button7");
      this.button7.Name = "button7";
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.button6.BackColor = Color.ForestGreen;
      componentResourceManager.ApplyResources((object) this.button6, "button6");
      this.button6.Name = "button6";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.SAVE.BackColor = Color.ForestGreen;
      componentResourceManager.ApplyResources((object) this.SAVE, "SAVE");
      this.SAVE.Name = "SAVE";
      this.SAVE.UseVisualStyleBackColor = false;
      this.SAVE.Click += new EventHandler(this.SAVE_Click);
      this.groupBox2.BackColor = Color.ForestGreen;
      this.groupBox2.Controls.Add((Control) this.button5);
      this.groupBox2.Controls.Add((Control) this.button3);
      this.groupBox2.Controls.Add((Control) this.button4);
      componentResourceManager.ApplyResources((object) this.groupBox2, "groupBox2");
      this.groupBox2.ForeColor = SystemColors.ButtonHighlight;
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.TabStop = false;
      this.groupBox2.Enter += new EventHandler(this.groupBox2_Enter);
      this.textBox3.BackColor = Color.Ivory;
      componentResourceManager.ApplyResources((object) this.textBox3, "textBox3");
      this.textBox3.Name = "textBox3";
      this.textBox3.TextChanged += new EventHandler(this.textBox3_TextChanged);
      this.groupBox3.Controls.Add((Control) this.textBox3);
      componentResourceManager.ApplyResources((object) this.groupBox3, "groupBox3");
      this.groupBox3.ForeColor = SystemColors.ButtonHighlight;
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.TabStop = false;
      componentResourceManager.ApplyResources((object) this.saveFileDialog1, "saveFileDialog1");
      this.saveFileDialog1.FileOk += new CancelEventHandler(this.saveFileDialog1_FileOk);
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.FileOk += new CancelEventHandler(this.openFileDialog1_FileOk);
      this.saveFileDialog3.FileOk += new CancelEventHandler(this.saveFileDialog3_FileOk);
      this.saveFileDialog4.FileOk += new CancelEventHandler(this.saveFileDialog4_FileOk);
      this.groupBox6.Controls.Add((Control) this.textBox2);
      componentResourceManager.ApplyResources((object) this.groupBox6, "groupBox6");
      this.groupBox6.ForeColor = SystemColors.ButtonHighlight;
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.TabStop = false;
      this.groupBox6.Enter += new EventHandler(this.groupBox6_Enter);
      componentResourceManager.ApplyResources((object) this.textBox2, "textBox2");
      this.textBox2.Name = "textBox2";
      this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
      this.groupBox4.Controls.Add((Control) this.textBox1);
      this.groupBox4.ForeColor = SystemColors.ButtonHighlight;
      componentResourceManager.ApplyResources((object) this.groupBox4, "groupBox4");
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.TabStop = false;
      this.groupBox4.Enter += new EventHandler(this.groupBox4_Enter);
      componentResourceManager.ApplyResources((object) this.textBox1, "textBox1");
      this.textBox1.Name = "textBox1";
      this.AllowDrop = true;
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.ForestGreen;
      this.Controls.Add((Control) this.groupBox4);
      this.Controls.Add((Control) this.groupBox6);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.menuStrip1);
      this.DoubleBuffered = true;
      this.ForeColor = SystemColors.ButtonHighlight;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = nameof (Form1);
      this.Load += new EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
