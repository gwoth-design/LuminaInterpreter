namespace Interpreter
{
    partial class LuminaMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.CodeMain = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileAsBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveCopyBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseIDEBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureIDLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodeMain
            // 
            this.CodeMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeMain.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CodeMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeMain.Location = new System.Drawing.Point(12, 40);
            this.CodeMain.Name = "CodeMain";
            this.CodeMain.Size = new System.Drawing.Size(776, 593);
            this.CodeMain.TabIndex = 1;
            this.CodeMain.Text = "";
            this.CodeMain.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.runToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileBTN,
            this.OpenFileBTN,
            this.SaveFileBTN,
            this.SaveFileAsBTN,
            this.SaveCopyBTN,
            this.CloseIDEBTN});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // NewFileBTN
            // 
            this.NewFileBTN.Name = "NewFileBTN";
            this.NewFileBTN.Size = new System.Drawing.Size(180, 22);
            this.NewFileBTN.Text = "New File";
            this.NewFileBTN.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // OpenFileBTN
            // 
            this.OpenFileBTN.Name = "OpenFileBTN";
            this.OpenFileBTN.Size = new System.Drawing.Size(180, 22);
            this.OpenFileBTN.Text = "Open";
            this.OpenFileBTN.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // SaveFileBTN
            // 
            this.SaveFileBTN.Name = "SaveFileBTN";
            this.SaveFileBTN.Size = new System.Drawing.Size(180, 22);
            this.SaveFileBTN.Text = "Save";
            this.SaveFileBTN.Click += new System.EventHandler(this.saveCopyAsToolStripMenuItem_Click);
            // 
            // SaveFileAsBTN
            // 
            this.SaveFileAsBTN.Name = "SaveFileAsBTN";
            this.SaveFileAsBTN.Size = new System.Drawing.Size(180, 22);
            this.SaveFileAsBTN.Text = "Save As";
            this.SaveFileAsBTN.Click += new System.EventHandler(this.saveCopyToolStripMenuItem_Click);
            // 
            // SaveCopyBTN
            // 
            this.SaveCopyBTN.Name = "SaveCopyBTN";
            this.SaveCopyBTN.Size = new System.Drawing.Size(180, 22);
            this.SaveCopyBTN.Text = "Save Copy";
            // 
            // CloseIDEBTN
            // 
            this.CloseIDEBTN.Name = "CloseIDEBTN";
            this.CloseIDEBTN.Size = new System.Drawing.Size(180, 22);
            this.CloseIDEBTN.Text = "Close IDE";
            this.CloseIDEBTN.Click += new System.EventHandler(this.closeIDEToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runProgramToolStripMenuItem,
            this.debugProgramToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // runProgramToolStripMenuItem
            // 
            this.runProgramToolStripMenuItem.Name = "runProgramToolStripMenuItem";
            this.runProgramToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.runProgramToolStripMenuItem.Text = "Run Program";
            this.runProgramToolStripMenuItem.Click += new System.EventHandler(this.runProgramToolStripMenuItem_Click);
            // 
            // debugProgramToolStripMenuItem
            // 
            this.debugProgramToolStripMenuItem.Name = "debugProgramToolStripMenuItem";
            this.debugProgramToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.debugProgramToolStripMenuItem.Text = "Debug Program";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureIDLEToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // configureIDLEToolStripMenuItem
            // 
            this.configureIDLEToolStripMenuItem.Name = "configureIDLEToolStripMenuItem";
            this.configureIDLEToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.configureIDLEToolStripMenuItem.Text = "Configure IDLE";
            this.configureIDLEToolStripMenuItem.Click += new System.EventHandler(this.configureIDLEToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.docsToolStripMenuItem,
            this.demoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // docsToolStripMenuItem
            // 
            this.docsToolStripMenuItem.Name = "docsToolStripMenuItem";
            this.docsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.docsToolStripMenuItem.Text = "Docs";
            // 
            // demoToolStripMenuItem
            // 
            this.demoToolStripMenuItem.Name = "demoToolStripMenuItem";
            this.demoToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.demoToolStripMenuItem.Text = "Demo";
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Location = new System.Drawing.Point(12, 24);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(35, 13);
            this.SaveLabel.TabIndex = 4;
            this.SaveLabel.Text = "label1";
            this.SaveLabel.Click += new System.EventHandler(this.SaveLabel_Click);
            // 
            // LuminaMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.CodeMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LuminaMainWindow";
            this.Text = "Lumina IDE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LuminaMainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LuminaMainWindow_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CodeMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem NewFileBTN;
        private System.Windows.Forms.ToolStripMenuItem OpenFileBTN;
        private System.Windows.Forms.ToolStripMenuItem SaveFileBTN;
        private System.Windows.Forms.ToolStripMenuItem SaveFileAsBTN;
        private System.Windows.Forms.ToolStripMenuItem SaveCopyBTN;
        private System.Windows.Forms.ToolStripMenuItem CloseIDEBTN;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureIDLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugProgramToolStripMenuItem;
        private System.Windows.Forms.Label SaveLabel;
    }
}

