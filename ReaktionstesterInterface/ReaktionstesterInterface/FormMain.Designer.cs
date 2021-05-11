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
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxTop = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxHighscores = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountdown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountdown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountdown3)).BeginInit();
            this.groupBoxName.SuspendLayout();
            this.groupBoxTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRS232});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(411, 24);
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
            this.toolStripMenuItemStart.Click += new System.EventHandler(this.ToolStripMenuItemSetup_Click);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemOpen.Text = "Open";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.ToolStripMenuItemOpen_Click);
            // 
            // toolStripMenuItemClose
            // 
            this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
            this.toolStripMenuItemClose.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.toolStripMenuItemClose.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemClose.Text = "Close";
            this.toolStripMenuItemClose.Click += new System.EventHandler(this.ToolStripMenuItemClose_Click);
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
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.pictureBoxCountdown1);
            this.flowLayoutPanel.Controls.Add(this.pictureBoxCountdown2);
            this.flowLayoutPanel.Controls.Add(this.pictureBoxCountdown3);
            this.flowLayoutPanel.Controls.Add(this.labelStatus);
            this.flowLayoutPanel.Controls.Add(this.buttonStart);
            this.flowLayoutPanel.Controls.Add(this.groupBoxName);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(411, 521);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // pictureBoxCountdown1
            // 
            this.pictureBoxCountdown1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxCountdown1.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCountdown1.Name = "pictureBoxCountdown1";
            this.pictureBoxCountdown1.Size = new System.Drawing.Size(130, 112);
            this.pictureBoxCountdown1.TabIndex = 1;
            this.pictureBoxCountdown1.TabStop = false;
            // 
            // pictureBoxCountdown2
            // 
            this.pictureBoxCountdown2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxCountdown2.Location = new System.Drawing.Point(139, 3);
            this.pictureBoxCountdown2.Name = "pictureBoxCountdown2";
            this.pictureBoxCountdown2.Size = new System.Drawing.Size(130, 112);
            this.pictureBoxCountdown2.TabIndex = 0;
            this.pictureBoxCountdown2.TabStop = false;
            // 
            // pictureBoxCountdown3
            // 
            this.pictureBoxCountdown3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxCountdown3.Location = new System.Drawing.Point(275, 3);
            this.pictureBoxCountdown3.Name = "pictureBoxCountdown3";
            this.pictureBoxCountdown3.Size = new System.Drawing.Size(130, 112);
            this.pictureBoxCountdown3.TabIndex = 2;
            this.pictureBoxCountdown3.TabStop = false;
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelStatus.Font = new System.Drawing.Font("Calibri", 18.25F);
            this.labelStatus.Location = new System.Drawing.Point(3, 118);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(402, 100);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(3, 221);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(402, 100);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.textBoxName);
            this.groupBoxName.Controls.Add(this.groupBoxTop);
            this.groupBoxName.Location = new System.Drawing.Point(3, 327);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(408, 177);
            this.groupBoxName.TabIndex = 2;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(10, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(385, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // groupBoxTop
            // 
            this.groupBoxTop.Controls.Add(this.tabControl);
            this.groupBoxTop.Location = new System.Drawing.Point(1, 47);
            this.groupBoxTop.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTop.Name = "groupBoxTop";
            this.groupBoxTop.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTop.Size = new System.Drawing.Size(402, 136);
            this.groupBoxTop.TabIndex = 5;
            this.groupBoxTop.TabStop = false;
            this.groupBoxTop.Text = "Bestenliste";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(2, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(398, 119);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxResults);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(390, 93);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxResults
            // 
            this.listBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(2, 2);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxResults.Size = new System.Drawing.Size(386, 89);
            this.listBoxResults.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxHighscores);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(390, 93);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxHighscores
            // 
            this.listBoxHighscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHighscores.FormattingEnabled = true;
            this.listBoxHighscores.Location = new System.Drawing.Point(2, 2);
            this.listBoxHighscores.Name = "listBoxHighscores";
            this.listBoxHighscores.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxHighscores.Size = new System.Drawing.Size(386, 89);
            this.listBoxHighscores.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 545);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reaktionstester";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountdown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountdown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountdown3)).EndInit();
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.groupBoxTop.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxTop;
        private System.Windows.Forms.ListBox listBoxHighscores;
        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.TextBox textBoxName;
    }
}

