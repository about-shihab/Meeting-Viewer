namespace MeetingViewer
{
    partial class MeetingViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetingViewer));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.remoteTabPage = new System.Windows.Forms.TabPage();
            this.remoteDesktop = new VncSharp.RemoteDesktop();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.reconnectLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.manualButton = new System.Windows.Forms.Button();
            this.remoteButton = new System.Windows.Forms.Button();
            this.livePictureBox = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.wellcomePictureBox = new System.Windows.Forms.PictureBox();
            this.connectMessageLabel = new System.Windows.Forms.Label();
            this.manualTabPage = new System.Windows.Forms.TabPage();
            this.browserPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.remoteTabPage.SuspendLayout();
            this.remoteDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wellcomePictureBox)).BeginInit();
            this.manualTabPage.SuspendLayout();
            this.browserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.remoteTabPage);
            this.tabControl1.Controls.Add(this.manualTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // remoteTabPage
            // 
            this.remoteTabPage.Controls.Add(this.remoteDesktop);
            this.remoteTabPage.Location = new System.Drawing.Point(4, 22);
            this.remoteTabPage.Name = "remoteTabPage";
            this.remoteTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.remoteTabPage.Size = new System.Drawing.Size(787, 466);
            this.remoteTabPage.TabIndex = 0;
            this.remoteTabPage.Text = "tabPage1";
            this.remoteTabPage.UseVisualStyleBackColor = true;
            // 
            // remoteDesktop
            // 
            this.remoteDesktop.AutoScroll = true;
            this.remoteDesktop.AutoScrollMinSize = new System.Drawing.Size(608, 427);
            this.remoteDesktop.Controls.Add(this.avatarPictureBox);
            this.remoteDesktop.Controls.Add(this.reconnectLabel);
            this.remoteDesktop.Controls.Add(this.topPanel);
            this.remoteDesktop.Controls.Add(this.connectMessageLabel);
            this.remoteDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteDesktop.Location = new System.Drawing.Point(3, 3);
            this.remoteDesktop.Name = "remoteDesktop";
            this.remoteDesktop.Size = new System.Drawing.Size(781, 460);
            this.remoteDesktop.TabIndex = 0;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.avatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("avatarPictureBox.Image")));
            this.avatarPictureBox.Location = new System.Drawing.Point(2495, 272);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(116, 116);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPictureBox.TabIndex = 7;
            this.avatarPictureBox.TabStop = false;
            // 
            // reconnectLabel
            // 
            this.reconnectLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reconnectLabel.AutoSize = true;
            this.reconnectLabel.BackColor = System.Drawing.Color.Black;
            this.reconnectLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reconnectLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reconnectLabel.Location = new System.Drawing.Point(469, 298);
            this.reconnectLabel.Name = "reconnectLabel";
            this.reconnectLabel.Size = new System.Drawing.Size(47, 17);
            this.reconnectLabel.TabIndex = 6;
            this.reconnectLabel.Text = "label1";
            this.reconnectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reconnectLabel.Visible = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.minimizeButton);
            this.topPanel.Controls.Add(this.manualButton);
            this.topPanel.Controls.Add(this.remoteButton);
            this.topPanel.Controls.Add(this.livePictureBox);
            this.topPanel.Controls.Add(this.timeLabel);
            this.topPanel.Controls.Add(this.connectButton);
            this.topPanel.Controls.Add(this.timerLabel);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Controls.Add(this.wellcomePictureBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(781, 34);
            this.topPanel.TabIndex = 0;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.DimGray;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimizeButton.Location = new System.Drawing.Point(710, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(30, 23);
            this.minimizeButton.TabIndex = 21;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // manualButton
            // 
            this.manualButton.BackColor = System.Drawing.Color.Gainsboro;
            this.manualButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manualButton.Location = new System.Drawing.Point(77, 1);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(79, 33);
            this.manualButton.TabIndex = 20;
            this.manualButton.Text = "Manual View";
            this.manualButton.UseVisualStyleBackColor = false;
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // remoteButton
            // 
            this.remoteButton.BackColor = System.Drawing.Color.White;
            this.remoteButton.FlatAppearance.BorderSize = 0;
            this.remoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remoteButton.Location = new System.Drawing.Point(0, 1);
            this.remoteButton.Name = "remoteButton";
            this.remoteButton.Size = new System.Drawing.Size(79, 33);
            this.remoteButton.TabIndex = 19;
            this.remoteButton.Text = "Remote View";
            this.remoteButton.UseVisualStyleBackColor = false;
            this.remoteButton.Click += new System.EventHandler(this.remoteButton_Click);
            // 
            // livePictureBox
            // 
            this.livePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.livePictureBox.Image = global::MeetingViewer.Properties.Resources.trends_51;
            this.livePictureBox.Location = new System.Drawing.Point(531, 3);
            this.livePictureBox.Name = "livePictureBox";
            this.livePictureBox.Size = new System.Drawing.Size(45, 26);
            this.livePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.livePictureBox.TabIndex = 17;
            this.livePictureBox.TabStop = false;
            this.livePictureBox.Visible = false;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(596, 8);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(40, 17);
            this.timeLabel.TabIndex = 16;
            this.timeLabel.Text = "Time:";
            this.timeLabel.Visible = false;
            // 
            // connectButton
            // 
            this.connectButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.connectButton.BackColor = System.Drawing.Color.Green;
            this.connectButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.ForeColor = System.Drawing.Color.Snow;
            this.connectButton.Location = new System.Drawing.Point(161, 0);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(99, 33);
            this.connectButton.TabIndex = 14;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(639, 5);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(60, 22);
            this.timerLabel.TabIndex = 15;
            this.timerLabel.Text = "timerLabel";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timerLabel.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.Location = new System.Drawing.Point(746, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // wellcomePictureBox
            // 
            this.wellcomePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wellcomePictureBox.Image = global::MeetingViewer.Properties.Resources.ezgif_com_crop__1_1;
            this.wellcomePictureBox.Location = new System.Drawing.Point(262, 2);
            this.wellcomePictureBox.Name = "wellcomePictureBox";
            this.wellcomePictureBox.Size = new System.Drawing.Size(212, 31);
            this.wellcomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wellcomePictureBox.TabIndex = 18;
            this.wellcomePictureBox.TabStop = false;
            // 
            // connectMessageLabel
            // 
            this.connectMessageLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.connectMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectMessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connectMessageLabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectMessageLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.connectMessageLabel.Location = new System.Drawing.Point(0, 0);
            this.connectMessageLabel.Name = "connectMessageLabel";
            this.connectMessageLabel.Size = new System.Drawing.Size(781, 460);
            this.connectMessageLabel.TabIndex = 5;
            this.connectMessageLabel.Text = "Press Connect to view";
            this.connectMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manualTabPage
            // 
            this.manualTabPage.Controls.Add(this.browserPanel);
            this.manualTabPage.Location = new System.Drawing.Point(4, 22);
            this.manualTabPage.Name = "manualTabPage";
            this.manualTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.manualTabPage.Size = new System.Drawing.Size(787, 466);
            this.manualTabPage.TabIndex = 1;
            this.manualTabPage.Text = "tabPage2";
            this.manualTabPage.UseVisualStyleBackColor = true;
            // 
            // browserPanel
            // 
            this.browserPanel.Controls.Add(this.forwardButton);
            this.browserPanel.Controls.Add(this.backButton);
            this.browserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserPanel.Location = new System.Drawing.Point(3, 3);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(781, 460);
            this.browserPanel.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(0, 30);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(27, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(28, 30);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(27, 23);
            this.forwardButton.TabIndex = 1;
            this.forwardButton.Text = ">";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // MeetingViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 492);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MeetingViewer";
            this.Text = "MeetingViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.remoteTabPage.ResumeLayout(false);
            this.remoteDesktop.ResumeLayout(false);
            this.remoteDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wellcomePictureBox)).EndInit();
            this.manualTabPage.ResumeLayout(false);
            this.browserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label connectMessageLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox wellcomePictureBox;
        private System.Windows.Forms.PictureBox livePictureBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button remoteButton;
        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage remoteTabPage;
        private VncSharp.RemoteDesktop remoteDesktop;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Label reconnectLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TabPage manualTabPage;
        private System.Windows.Forms.Panel browserPanel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button backButton;
    }
}