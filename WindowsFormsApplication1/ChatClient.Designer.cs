namespace WindowsFormsApplication1
{
    partial class ChatClient
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
            this.components = new System.ComponentModel.Container();
            this.messageView = new System.Windows.Forms.ListBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.timerMessageView = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // messageView
            // 
            this.messageView.FormattingEnabled = true;
            this.messageView.Location = new System.Drawing.Point(12, 12);
            this.messageView.Name = "messageView";
            this.messageView.Size = new System.Drawing.Size(471, 238);
            this.messageView.TabIndex = 0;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 256);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(361, 20);
            this.messageBox.TabIndex = 1;
            this.messageBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messageBox_KeyUp);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(379, 256);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(104, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Enviar";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // timerMessageView
            // 
            this.timerMessageView.Enabled = true;
            this.timerMessageView.Interval = 1;
            this.timerMessageView.Tick += new System.EventHandler(this.timerMessageView_Tick);
            // 
            // ChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 315);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.messageView);
            this.Name = "ChatClient";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatClient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox messageView;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Timer timerMessageView;
    }
}