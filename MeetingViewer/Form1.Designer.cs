namespace MeetingViewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.forwardButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.reconnectLabel = new System.Windows.Forms.Label();
            this.connectMessageLabel = new System.Windows.Forms.Label();
            this.meetingOngoinglabel = new System.Windows.Forms.Label();
            this.remoteDesktop = new VncSharp.RemoteDesktop();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fullScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.wellcomePictureBox = new System.Windows.Forms.PictureBox();
            this.livePictureBox = new System.Windows.Forms.PictureBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.remoteDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wellcomePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livePictureBox)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // forwardButton
            // 
            this.forwardButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.forwardButton.BackgroundImage = global::MeetingViewer.Properties.Resources.forward;
            this.forwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forwardButton.Location = new System.Drawing.Point(345, -3);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(32, 24);
            this.forwardButton.TabIndex = 0;
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.forwardButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 462);
            this.panel1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backButton.BackgroundImage = global::MeetingViewer.Properties.Resources.back;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(258, -3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(32, 24);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual View";
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(527, 7);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(40, 17);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "Time:";
            this.timeLabel.Visible = false;
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(548, 1);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(101, 29);
            this.timerLabel.TabIndex = 10;
            this.timerLabel.Text = "timerLabel";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timerLabel.Visible = false;
            // 
            // reconnectLabel
            // 
            this.reconnectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reconnectLabel.BackColor = System.Drawing.Color.Black;
            this.reconnectLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reconnectLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reconnectLabel.Location = new System.Drawing.Point(196, 256);
            this.reconnectLabel.Name = "reconnectLabel";
            this.reconnectLabel.Size = new System.Drawing.Size(441, 30);
            this.reconnectLabel.TabIndex = 3;
            this.reconnectLabel.Text = "label1";
            this.reconnectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reconnectLabel.Visible = false;
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
            this.connectMessageLabel.Size = new System.Drawing.Size(666, 427);
            this.connectMessageLabel.TabIndex = 2;
            this.connectMessageLabel.Text = "Press Connect to view";
            this.connectMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meetingOngoinglabel
            // 
            this.meetingOngoinglabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.meetingOngoinglabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingOngoinglabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.meetingOngoinglabel.Location = new System.Drawing.Point(17, -3);
            this.meetingOngoinglabel.Name = "meetingOngoinglabel";
            this.meetingOngoinglabel.Size = new System.Drawing.Size(632, 35);
            this.meetingOngoinglabel.TabIndex = 14;
            this.meetingOngoinglabel.Text = "Welcome ";
            this.meetingOngoinglabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.meetingOngoinglabel.Visible = false;
            // 
            // remoteDesktop
            // 
            this.remoteDesktop.AutoScroll = true;
            this.remoteDesktop.AutoScrollMinSize = new System.Drawing.Size(608, 427);
            this.remoteDesktop.AutoSize = true;
            this.remoteDesktop.Controls.Add(this.avatarPictureBox);
            this.remoteDesktop.Controls.Add(this.reconnectLabel);
            this.remoteDesktop.Controls.Add(this.connectMessageLabel);
            this.remoteDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteDesktop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.remoteDesktop.Location = new System.Drawing.Point(0, 0);
            this.remoteDesktop.Name = "remoteDesktop";
            this.remoteDesktop.Size = new System.Drawing.Size(666, 427);
            this.remoteDesktop.TabIndex = 3;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.avatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("avatarPictureBox.Image")));
            this.avatarPictureBox.Location = new System.Drawing.Point(417, 58);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(116, 116);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPictureBox.TabIndex = 4;
            this.avatarPictureBox.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fullScreenCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.wellcomePictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.livePictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.timeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.connectButton);
            this.splitContainer1.Panel1.Controls.Add(this.timerLabel);
            this.splitContainer1.Panel1.Controls.Add(this.meetingOngoinglabel);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.remoteDesktop);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(666, 462);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.TabIndex = 0;
            // 
            // fullScreenCheckBox
            // 
            this.fullScreenCheckBox.AutoSize = true;
            this.fullScreenCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullScreenCheckBox.Location = new System.Drawing.Point(152, 7);
            this.fullScreenCheckBox.Name = "fullScreenCheckBox";
            this.fullScreenCheckBox.Size = new System.Drawing.Size(78, 17);
            this.fullScreenCheckBox.TabIndex = 15;
            this.fullScreenCheckBox.Text = "Full Screen";
            this.fullScreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // wellcomePictureBox
            // 
            this.wellcomePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wellcomePictureBox.Image = global::MeetingViewer.Properties.Resources.ezgif_com_crop__1_1;
            this.wellcomePictureBox.Location = new System.Drawing.Point(196, -1);
            this.wellcomePictureBox.Name = "wellcomePictureBox";
            this.wellcomePictureBox.Size = new System.Drawing.Size(213, 31);
            this.wellcomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wellcomePictureBox.TabIndex = 13;
            this.wellcomePictureBox.TabStop = false;
            // 
            // livePictureBox
            // 
            this.livePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.livePictureBox.Image = global::MeetingViewer.Properties.Resources.trends_51;
            this.livePictureBox.Location = new System.Drawing.Point(412, 1);
            this.livePictureBox.Name = "livePictureBox";
            this.livePictureBox.Size = new System.Drawing.Size(109, 26);
            this.livePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.livePictureBox.TabIndex = 12;
            this.livePictureBox.TabStop = false;
            this.livePictureBox.Visible = false;
            // 
            // connectButton
            // 
            this.connectButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.connectButton.BackColor = System.Drawing.Color.Green;
            this.connectButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.ForeColor = System.Drawing.Color.Snow;
            this.connectButton.Location = new System.Drawing.Point(-3, -3);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(149, 33);
            this.connectButton.TabIndex = 9;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Remote View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 497);
            this.tabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 497);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.remoteDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wellcomePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livePictureBox)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox wellcomePictureBox;
        private System.Windows.Forms.PictureBox livePictureBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label reconnectLabel;
        private System.Windows.Forms.Label connectMessageLabel;
        private System.Windows.Forms.Label meetingOngoinglabel;
        private VncSharp.RemoteDesktop remoteDesktop;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox fullScreenCheckBox;
        private System.Windows.Forms.Button connectButton;
    }
}