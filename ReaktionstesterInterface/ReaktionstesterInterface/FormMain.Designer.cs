namespace ReaktionstesterInterface
{
    partial class FormMain
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemRS232 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxCountdown1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCountdown2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCountdown3 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountdown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountdown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountdown3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox.Location = new System.Drawing.Point(0, 156);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(445, 401);
            this.textBox.TabIndex = 0;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRS232});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(445, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemRS232
            // 
            this.toolStripMenuItemRS232.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStart,
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemClose,
            this.toolStripSeparator,
            this.toolStripMenuItemExit});
            this.toolStripMenuItemRS232.Name = "toolStripMenuItemRS232";
            this.toolStripMenuItemRS232.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItemRS232.Text = "RS232";
            // 
            // toolStripMenuItemStart
            // 
            this.toolStripMenuItemStart.Name = "toolStripMenuItemStart";
            this.toolStripMenuItemStart.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.toolStripMenuItemStart.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemStart.Text = "Setup";
            this.toolStripMenuItemStart.Click += new System.EventHandler(this.toolStripMenuItemSetup_Click);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemOpen.Text = "Open";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // toolStripMenuItemClose
            // 
            this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
            this.toolStripMenuItemClose.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.toolStripMenuItemClose.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemClose.Text = "Close";
            this.toolStripMenuItemClose.Click += new System.EventHandler(this.toolStripMenuItemClose_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(132, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.pictureBoxCountdown1);
            this.flowLayoutPanel.Controls.Add(this.pictureBoxCountdown2);
            this.flowLayoutPanel.Controls.Add(this.pictureBoxCountdown3);
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(421, 123);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // pictureBoxCountdown1
            // 
            this.pictureBoxCountdown1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxCountdown1.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCountdown1.Name = "pictureBoxCountdown1";
            this.pictureBoxCountdown1.Size = new System.Drawing.Size(135, 112);
            this.pictureBoxCountdown1.TabIndex = 1;
            this.pictureBoxCountdown1.TabStop = false;
            // 
            // pictureBoxCountdown2
            // 
            this.pictureBoxCountdown2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxCountdown2.Location = new System.Drawing.Point(144, 3);
            this.pictureBoxCountdown2.Name = "pictureBoxCountdown2";
            this.pictureBoxCountdown2.Size = new System.Drawing.Size(129, 112);
            this.pictureBoxCountdown2.TabIndex = 0;
            this.pictureBoxCountdown2.TabStop = false;
            // 
            // pictureBoxCountdown3
            // 
            this.pictureBoxCountdown3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxCountdown3.Location = new System.Drawing.Point(279, 3);
            this.pictureBoxCountdown3.Name = "pictureBoxCountdown3";
            this.pictureBoxCountdown3.Size = new System.Drawing.Size(135, 112);
            this.pictureBoxCountdown3.TabIndex = 2;
            this.pictureBoxCountdown3.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 557);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "FormMain";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountdown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountdown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountdown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRS232;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBoxCountdown1;
        private System.Windows.Forms.PictureBox pictureBoxCountdown2;
        private System.Windows.Forms.PictureBox pictureBoxCountdown3;
    }
}

