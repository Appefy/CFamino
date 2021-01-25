
namespace CFamino
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GCode = new System.Windows.Forms.GroupBox();
            this.GOutput = new System.Windows.Forms.GroupBox();
            this.GInput = new System.Windows.Forms.GroupBox();
            this.code = new System.Windows.Forms.RichTextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.input = new System.Windows.Forms.RichTextBox();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.buildPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.set_compiler = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.GCode.SuspendLayout();
            this.GOutput.SuspendLayout();
            this.GInput.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.buildToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1283, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.cToolStripMenuItem1});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.newToolStripMenuItem.Text = "New";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.cToolStripMenuItem.Text = "C";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem1
            // 
            this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            this.cToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.cToolStripMenuItem1.Text = "C++";
            this.cToolStripMenuItem1.Click += new System.EventHandler(this.cToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.saveAsToolStripMenuItem.Text = "Save";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildPathToolStripMenuItem,
            this.compileToolStripMenuItem,
            this.runToolStripMenuItem});
            this.buildToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.buildToolStripMenuItem.Text = "Build";
            this.buildToolStripMenuItem.Click += new System.EventHandler(this.buildToolStripMenuItem_Click);
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.compileToolStripMenuItem.Text = "Compile";
            this.compileToolStripMenuItem.Click += new System.EventHandler(this.compileToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // GCode
            // 
            this.GCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GCode.Controls.Add(this.code);
            this.GCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCode.ForeColor = System.Drawing.SystemColors.Control;
            this.GCode.Location = new System.Drawing.Point(12, 34);
            this.GCode.Name = "GCode";
            this.GCode.Size = new System.Drawing.Size(979, 632);
            this.GCode.TabIndex = 1;
            this.GCode.TabStop = false;
            this.GCode.Text = "Code";
            // 
            // GOutput
            // 
            this.GOutput.Controls.Add(this.output);
            this.GOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.GOutput.Location = new System.Drawing.Point(997, 34);
            this.GOutput.Name = "GOutput";
            this.GOutput.Size = new System.Drawing.Size(274, 358);
            this.GOutput.TabIndex = 0;
            this.GOutput.TabStop = false;
            this.GOutput.Text = "Output";
            // 
            // GInput
            // 
            this.GInput.Controls.Add(this.input);
            this.GInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GInput.ForeColor = System.Drawing.SystemColors.Control;
            this.GInput.Location = new System.Drawing.Point(997, 398);
            this.GInput.Name = "GInput";
            this.GInput.Size = new System.Drawing.Size(274, 268);
            this.GInput.TabIndex = 2;
            this.GInput.TabStop = false;
            this.GInput.Text = "Input";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(6, 29);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(967, 597);
            this.code.TabIndex = 0;
            this.code.Text = "";
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(6, 29);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(262, 323);
            this.output.TabIndex = 0;
            this.output.Text = "";
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(7, 30);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(261, 232);
            this.input.TabIndex = 0;
            this.input.Text = "";
            // 
            // open
            // 
            this.open.FileOk += new System.ComponentModel.CancelEventHandler(this.open_FileOk);
            // 
            // save
            // 
            this.save.FileOk += new System.ComponentModel.CancelEventHandler(this.save_FileOk);
            // 
            // buildPathToolStripMenuItem
            // 
            this.buildPathToolStripMenuItem.Name = "buildPathToolStripMenuItem";
            this.buildPathToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.buildPathToolStripMenuItem.Text = "Compiler";
            this.buildPathToolStripMenuItem.Click += new System.EventHandler(this.buildPathToolStripMenuItem_Click);
            // 
            // set_compiler
            // 
            this.set_compiler.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.set_compiler.HelpRequest += new System.EventHandler(this.set_compiler_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.GInput);
            this.Controls.Add(this.GOutput);
            this.Controls.Add(this.GCode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CFamino";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GCode.ResumeLayout(false);
            this.GOutput.ResumeLayout(false);
            this.GInput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

