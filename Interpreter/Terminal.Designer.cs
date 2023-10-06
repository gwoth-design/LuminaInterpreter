namespace Interpreter
{
    partial class Terminal
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
            this.Console = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Console
            // 
            this.Console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Console.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Console.Location = new System.Drawing.Point(12, 12);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(607, 610);
            this.Console.TabIndex = 0;
            this.Console.Text = "";
            this.Console.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(631, 634);
            this.Controls.Add(this.Console);
            this.Name = "Terminal";
            this.Text = "Terminal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Console;
    }
}