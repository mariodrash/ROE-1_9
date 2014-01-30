namespace ROE.Templates
{
    partial class B2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B2));
            this.titleLabel = new System.Windows.Forms.Label();
            this.videoGroup = new System.Windows.Forms.GroupBox();
            this.backgroundVideo = new System.Windows.Forms.Panel();
            this.videoDisplay = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.btnBackward = new System.Windows.Forms.PictureBox();
            this.btnForward = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.barTitle = new System.Windows.Forms.Label();
            this.infoSong = new System.Windows.Forms.GroupBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblSinger = new System.Windows.Forms.Label();
            this.nameSongLbl = new System.Windows.Forms.Label();
            this.coverImage = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.progressVideo = new System.Windows.Forms.Timer(this.components);
            this.videoGroup.SuspendLayout();
            this.backgroundVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.panel3.SuspendLayout();
            this.infoSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("AltamonteNF", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.titleLabel.Location = new System.Drawing.Point(678, 38);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(337, 65);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title Activity";
            // 
            // videoGroup
            // 
            this.videoGroup.BackColor = System.Drawing.Color.DarkGray;
            this.videoGroup.Controls.Add(this.backgroundVideo);
            this.videoGroup.Controls.Add(this.btnBackward);
            this.videoGroup.Controls.Add(this.btnForward);
            this.videoGroup.Controls.Add(this.btnPause);
            this.videoGroup.Controls.Add(this.btnStop);
            this.videoGroup.Controls.Add(this.btnPlay);
            this.videoGroup.Font = new System.Drawing.Font("AltamonteNF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoGroup.Location = new System.Drawing.Point(30, 113);
            this.videoGroup.Name = "videoGroup";
            this.videoGroup.Size = new System.Drawing.Size(536, 508);
            this.videoGroup.TabIndex = 145;
            this.videoGroup.TabStop = false;
            this.videoGroup.Text = "VIDEO";
            // 
            // backgroundVideo
            // 
            this.backgroundVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.backgroundVideo.Controls.Add(this.videoDisplay);
            this.backgroundVideo.Location = new System.Drawing.Point(11, 28);
            this.backgroundVideo.Name = "backgroundVideo";
            this.backgroundVideo.Size = new System.Drawing.Size(509, 341);
            this.backgroundVideo.TabIndex = 7;
            // 
            // videoDisplay
            // 
            this.videoDisplay.Enabled = true;
            this.videoDisplay.Location = new System.Drawing.Point(13, 15);
            this.videoDisplay.Name = "videoDisplay";
            this.videoDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoDisplay.OcxState")));
            this.videoDisplay.Size = new System.Drawing.Size(481, 311);
            this.videoDisplay.TabIndex = 0;
            // 
            // btnBackward
            // 
            this.btnBackward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackward.Image = global::ROE.Templates.Properties.Resources.black_farward_button_md;
            this.btnBackward.Location = new System.Drawing.Point(130, 399);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(84, 76);
            this.btnBackward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBackward.TabIndex = 6;
            this.btnBackward.TabStop = false;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            this.btnBackward.MouseEnter += new System.EventHandler(this.ButtonGUI_MouseEnter);
            this.btnBackward.MouseLeave += new System.EventHandler(this.ButtonGUI_MouseLeave);
            // 
            // btnForward
            // 
            this.btnForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForward.Image = global::ROE.Templates.Properties.Resources.black_farward_button_md1;
            this.btnForward.Location = new System.Drawing.Point(317, 399);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(84, 76);
            this.btnForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnForward.TabIndex = 5;
            this.btnForward.TabStop = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            this.btnForward.MouseEnter += new System.EventHandler(this.ButtonGUI_MouseEnter);
            this.btnForward.MouseLeave += new System.EventHandler(this.ButtonGUI_MouseLeave);
            // 
            // btnPause
            // 
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Image = global::ROE.Templates.Properties.Resources.black_pause_button_md;
            this.btnPause.Location = new System.Drawing.Point(410, 398);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(84, 76);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPause.TabIndex = 3;
            this.btnPause.TabStop = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            this.btnPause.MouseEnter += new System.EventHandler(this.ButtonGUI_MouseEnter);
            this.btnPause.MouseLeave += new System.EventHandler(this.ButtonGUI_MouseLeave);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Image = global::ROE.Templates.Properties.Resources.black_stop_button_md;
            this.btnStop.Location = new System.Drawing.Point(36, 398);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(84, 76);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStop.TabIndex = 2;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.MouseEnter += new System.EventHandler(this.ButtonGUI_MouseEnter);
            this.btnStop.MouseLeave += new System.EventHandler(this.ButtonGUI_MouseLeave);
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Image = global::ROE.Templates.Properties.Resources.black_play_button_md;
            this.btnPlay.Location = new System.Drawing.Point(223, 399);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(84, 76);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 1;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseEnter += new System.EventHandler(this.ButtonGUI_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.ButtonGUI_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Controls.Add(this.barTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1533, 31);
            this.panel3.TabIndex = 146;
            // 
            // barTitle
            // 
            this.barTitle.AutoSize = true;
            this.barTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barTitle.ForeColor = System.Drawing.Color.White;
            this.barTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.barTitle.Location = new System.Drawing.Point(793, 5);
            this.barTitle.Name = "barTitle";
            this.barTitle.Size = new System.Drawing.Size(326, 20);
            this.barTitle.TabIndex = 0;
            this.barTitle.Text = "♫ Boulevard of broken dreams | Green Day ♫";
            // 
            // infoSong
            // 
            this.infoSong.BackColor = System.Drawing.Color.DarkGray;
            this.infoSong.Controls.Add(this.lblAlbum);
            this.infoSong.Controls.Add(this.lblSinger);
            this.infoSong.Controls.Add(this.nameSongLbl);
            this.infoSong.Controls.Add(this.coverImage);
            this.infoSong.Font = new System.Drawing.Font("AltamonteNF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoSong.Location = new System.Drawing.Point(75, 665);
            this.infoSong.Name = "infoSong";
            this.infoSong.Size = new System.Drawing.Size(434, 149);
            this.infoSong.TabIndex = 147;
            this.infoSong.TabStop = false;
            this.infoSong.Text = "INFO";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Aklatanic TSO", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.ForeColor = System.Drawing.Color.White;
            this.lblAlbum.Location = new System.Drawing.Point(152, 108);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(61, 19);
            this.lblAlbum.TabIndex = 7;
            this.lblAlbum.Text = "Album:";
            // 
            // lblSinger
            // 
            this.lblSinger.AutoSize = true;
            this.lblSinger.Font = new System.Drawing.Font("Aklatanic TSO", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinger.ForeColor = System.Drawing.Color.White;
            this.lblSinger.Location = new System.Drawing.Point(152, 76);
            this.lblSinger.Name = "lblSinger";
            this.lblSinger.Size = new System.Drawing.Size(52, 19);
            this.lblSinger.TabIndex = 6;
            this.lblSinger.Text = "Artist:";
            // 
            // nameSongLbl
            // 
            this.nameSongLbl.AutoSize = true;
            this.nameSongLbl.Font = new System.Drawing.Font("Aklatanic TSO", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSongLbl.ForeColor = System.Drawing.Color.White;
            this.nameSongLbl.Location = new System.Drawing.Point(152, 46);
            this.nameSongLbl.Name = "nameSongLbl";
            this.nameSongLbl.Size = new System.Drawing.Size(154, 19);
            this.nameSongLbl.TabIndex = 5;
            this.nameSongLbl.Text = "\"All Together Now\"";
            // 
            // coverImage
            // 
            this.coverImage.Location = new System.Drawing.Point(15, 26);
            this.coverImage.Name = "coverImage";
            this.coverImage.Size = new System.Drawing.Size(126, 118);
            this.coverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverImage.TabIndex = 4;
            this.coverImage.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Image = global::ROE.Templates.Properties.Resources.HelpB2_01;
            this.btnHelp.Location = new System.Drawing.Point(1036, 698);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(130, 116);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHelp.TabIndex = 148;
            this.btnHelp.TabStop = false;
            this.btnHelp.MouseEnter += new System.EventHandler(this.ButtonGUI_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.ButtonGUI_MouseLeave);
            // 
            // progressVideo
            // 
            this.progressVideo.Interval = 1;
            this.progressVideo.Tick += new System.EventHandler(this.progressVideo_Tick);
            // 
            // B2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1533, 850);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.infoSong);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.videoGroup);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "B2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B2";
            this.videoGroup.ResumeLayout(false);
            this.backgroundVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.infoSong.ResumeLayout(false);
            this.infoSong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox videoGroup;
        private System.Windows.Forms.Panel backgroundVideo;
        private AxShockwaveFlashObjects.AxShockwaveFlash videoDisplay;
        private System.Windows.Forms.PictureBox btnBackward;
        private System.Windows.Forms.PictureBox btnForward;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Label barTitle;
        private System.Windows.Forms.GroupBox infoSong;
        protected System.Windows.Forms.Label nameSongLbl;
        protected System.Windows.Forms.PictureBox coverImage;
        protected System.Windows.Forms.Label lblAlbum;
        protected System.Windows.Forms.Label lblSinger;
        protected System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.Timer progressVideo;
    }
}