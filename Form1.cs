// Decompiled with JetBrains decompiler
// Type: CFamino.Form1
// Assembly: CFamino, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 50EBCE2E-C188-47DB-93F0-CB3E30234170
// Assembly location: C:\Users\Prithwiraj Samanta\Documents\GitHub\CFamino\bin\Debug\CFamino.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CFamino
{
    partial class Form1 : Form
    {
        private string curpath = "empty";
        private string curfile = "empty";
        private string compile_path = "empty";
        private bool is_compile = false;
        private bool compile_ok = false;
        private IContainer components = (IContainer)null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem buildToolStripMenuItem;
        private ToolStripMenuItem compileToolStripMenuItem;
        private ToolStripMenuItem runToolStripMenuItem;
        private GroupBox GCode;
        private GroupBox GOutput;
        private GroupBox GInput;
        private RichTextBox code;
        private RichTextBox output;
        private RichTextBox input;
        private OpenFileDialog open;
        private SaveFileDialog save;
        private ToolStripMenuItem buildPathToolStripMenuItem;
        private FolderBrowserDialog set_compiler;

        public Form1() => this.InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.save.AutoUpgradeEnabled = true;
            this.save.Title = "Create a new C File";
            this.save.DefaultExt = ".c";
            int num = (int)this.save.ShowDialog();
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.save.AutoUpgradeEnabled = true;
            this.save.Title = "Create a new C++ File";
            this.save.DefaultExt = ".cpp";
            int num = (int)this.save.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.curfile.Equals("empty"))
            {
                this.save.AutoUpgradeEnabled = true;
                this.save.Title = "Save As";
                this.save.DefaultExt = ".cpp";
                int num = (int)this.save.ShowDialog();
            }
            StreamWriter streamWriter = new StreamWriter(this.curpath);
            streamWriter.WriteLine(this.code.Text);
            streamWriter.Flush();
            streamWriter.Close();
            streamWriter.Dispose();
            this.GCode.Text = this.curfile;
            this.is_compile = false;
        }

        private void save_FileOk(object sender, CancelEventArgs e)
        {
            if (this.curfile.Equals("empty"))
                this.code.Text = "";
            File.Create(this.save.FileName).Close();
            string fileName = this.save.FileName;
            this.GCode.Text = fileName.Substring(fileName.LastIndexOf('\\')).TrimStart('\\');
            this.curpath = this.save.FileName;
            this.curfile = fileName.Substring(fileName.LastIndexOf('\\')).TrimStart('\\');
            this.is_compile = false;
            this.save.Dispose();
        }

        private void buildToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.open.CheckFileExists = true;
            this.open.AutoUpgradeEnabled = true;
            this.open.Title = "Open File";
            int num = (int)this.open.ShowDialog();
        }

        private void open_FileOk(object sender, CancelEventArgs e)
        {
            StreamReader streamReader = new StreamReader(this.open.FileName);
            string str1 = "";
            string str2;
            while ((str2 = streamReader.ReadLine()) != null)
                str1 = str1 + Environment.NewLine + str2;
            this.code.Text = str1;
            string fileName = this.open.FileName;
            this.GCode.Text = fileName.Substring(fileName.LastIndexOf('\\')).TrimStart('\\');
            this.curpath = this.open.FileName;
            this.curfile = fileName.Substring(fileName.LastIndexOf('\\')).TrimStart('\\');
            streamReader.Close();
            streamReader.Dispose();
            this.is_compile = false;
            this.open.Dispose();
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.compile_path.Equals("empty"))
            {
                if (this.set_compiler.ShowDialog() == DialogResult.OK)
                {
                    this.compile_path = this.set_compiler.SelectedPath;
                    Console.WriteLine(this.compile_path);
                    this.is_compile = false;
                    this.save.Dispose();
                }
                else
                    this.compileToolStripMenuItem_Click(sender, e);
            }
            if (this.is_compile)
                return;
            this.compile();
            this.is_compile = true;
        }

        private void buildPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.save.AutoUpgradeEnabled = true;
            this.save.Title = "Set Location of bin folder of Compiler";
            if (this.set_compiler.ShowDialog() == DialogResult.OK)
            {
                this.compile_path = this.set_compiler.SelectedPath;
                Console.WriteLine(this.compile_path);
                this.is_compile = false;
                this.save.Dispose();
            }
            else
                this.buildPathToolStripMenuItem_Click(sender, e);
        }

        private void compile()
        {
            this.output.Text = "";
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
            standardInput.WriteLine("cd " + this.compile_path);
            string str3 = !(this.curfile.Substring(this.curfile.LastIndexOf('.')) == ".cpp") ? "gcc -w " : "g++ -w ";
            standardInput.WriteLine(str3 + this.curpath + " -o " + this.curpath.Substring(0, this.curpath.LastIndexOf('\\')) + "\\" + this.curfile.Substring(0, this.curfile.LastIndexOf('.')));
            standardInput.Flush();
            standardInput.Close();
            string str4;
            while ((str4 = standardOutput.ReadLine()) != null)
                str2 = str2 + Environment.NewLine + str4;
            this.output.Text = "Compile Log:" + Environment.NewLine + str2;
            standardOutput.Close();
            string str5;
            while ((str5 = standardError.ReadLine()) != null)
                str1 = str1 + Environment.NewLine + str5;
            if (str1.Equals(""))
                this.compile_ok = true;
            this.output.Text = this.output.Text + Environment.NewLine + "Error Log:" + Environment.NewLine + str1;
            standardError.Close();
        }

        private void run()
        {
            if (!this.compile_ok)
            {
                this.output.Text = "Compilation is not successfull.\n Can't run code";
            }
            else
            {
                this.output.Text = "";
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
                standardInput.WriteLine(this.input.Text);
                standardInput.Flush();
                standardInput.Close();
                string str3;
                while ((str3 = standardOutput.ReadLine()) != null)
                    str2 = str2 + Environment.NewLine + str3;
                this.output.Text = "STDOUT:" + Environment.NewLine + str2;
                standardOutput.Close();
                string str4;
                while ((str4 = standardError.ReadLine()) != null)
                    str1 = str1 + Environment.NewLine + str4;
                if (str1 != "")
                {
                    this.output.Text = Environment.NewLine;
                    this.output.Text = this.output.Text + Environment.NewLine + "STDERR:" + Environment.NewLine + str1;
                }
                standardError.Close();
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.is_compile)
                this.output.Text = "Compile code first";
            else
                this.run();
        }

        private void set_compiler_HelpRequest(object sender, EventArgs e)
        {
        }
    }
}
