namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.ipHostBox = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.butttonStart = new System.Windows.Forms.Button();
            this.portHostBox = new System.Windows.Forms.TextBox();
            this.ignored = new System.Windows.Forms.Label();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipHostBox
            // 
            this.ipHostBox.Location = new System.Drawing.Point(30, 60);
            this.ipHostBox.Name = "ipHostBox";
            this.ipHostBox.Size = new System.Drawing.Size(164, 20);
            this.ipHostBox.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(159, 99);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(102, 23);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Entrar";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 181);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(294, 22);
            this.statusBar.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.LinkVisited = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel1.Text = "Status Server";
            // 
            // butttonStart
            // 
            this.butttonStart.Location = new System.Drawing.Point(30, 99);
            this.butttonStart.Name = "butttonStart";
            this.butttonStart.Size = new System.Drawing.Size(102, 23);
            this.butttonStart.TabIndex = 3;
            this.butttonStart.Text = "Criar";
            this.butttonStart.UseVisualStyleBackColor = true;
            this.butttonStart.Click += new System.EventHandler(this.butttonStart_Click);
            // 
            // portHostBox
            // 
            this.portHostBox.Location = new System.Drawing.Point(216, 60);
            this.portHostBox.Name = "portHostBox";
            this.portHostBox.Size = new System.Drawing.Size(45, 20);
            this.portHostBox.TabIndex = 4;
            // 
            // ignored
            // 
            this.ignored.AutoSize = true;
            this.ignored.Location = new System.Drawing.Point(200, 63);
            this.ignored.Name = "ignored";
            this.ignored.Size = new System.Drawing.Size(10, 13);
            this.ignored.TabIndex = 5;
            this.ignored.Text = ":";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 203);
            this.Controls.Add(this.ignored);
            this.Controls.Add(this.portHostBox);
            this.Controls.Add(this.butttonStart);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.ipHostBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipHostBox;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button butttonStart;
        private System.Windows.Forms.TextBox portHostBox;
        private System.Windows.Forms.Label ignored;
    }
}

