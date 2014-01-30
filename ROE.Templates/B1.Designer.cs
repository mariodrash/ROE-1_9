namespace ROE.Templates
{
    partial class B1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B1));
            this.topicLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.barTitle = new System.Windows.Forms.Label();
            this.videoGroup = new System.Windows.Forms.GroupBox();
            this.backgroundVideo = new System.Windows.Forms.Panel();
            this.btnBackward = new System.Windows.Forms.PictureBox();
            this.btnForward = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.infoGroup = new System.Windows.Forms.GroupBox();
            this.lbSing = new System.Windows.Forms.Label();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.lbSong = new System.Windows.Forms.Label();
            this.picAlbum = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.progressVideo = new System.Windows.Forms.Timer(this.components);
            this.videoDisplay = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.panel3.SuspendLayout();
            this.videoGroup.SuspendLayout();
            this.backgroundVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.infoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.Font = new System.Drawing.Font("AltamonteNF", 27.75F, System.Drawing.FontStyle.Bold);
            this.topicLabel.ForeColor = System.Drawing.Color.Yellow;
            this.topicLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.topicLabel.Location = new System.Drawing.Point(632, 33);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(415, 50);
            this.topicLabel.TabIndex = 55;
            this.topicLabel.Text = "prepositions of place";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(101)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.barTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1533, 31);
            this.panel3.TabIndex = 68;
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
            // videoGroup
            // 
            this.videoGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(81)))));
            this.videoGroup.Controls.Add(this.backgroundVideo);
            this.videoGroup.Controls.Add(this.btnBackward);
            this.videoGroup.Controls.Add(this.btnForward);
            this.videoGroup.Controls.Add(this.btnPause);
            this.videoGroup.Controls.Add(this.btnStop);
            this.videoGroup.Controls.Add(this.btnPlay);
            this.videoGroup.Font = new System.Drawing.Font("AltamonteNF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoGroup.Location = new System.Drawing.Point(25, 108);
            this.videoGroup.Name = "videoGroup";
            this.videoGroup.Size = new System.Drawing.Size(536, 508);
            this.videoGroup.TabIndex = 144;
            this.videoGroup.TabStop = false;
            this.videoGroup.Text = "VIDEO";
            // 
            // backgroundVideo
            // 
            this.backgroundVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backgroundVideo.Controls.Add(this.videoDisplay);
            this.backgroundVideo.Location = new System.Drawing.Point(11, 28);
            this.backgroundVideo.Name = "backgroundVideo";
            this.backgroundVideo.Size = new System.Drawing.Size(509, 341);
            this.backgroundVideo.TabIndex = 7;
            // 
            // btnBackward
            // 
            this.btnBackward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackward.Image = global::ROE.Templates.Properties.Resources.green_backward_button_md;
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
            this.btnForward.Image = global::ROE.Templates.Properties.Resources.green_forward_button_md;
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
            this.btnPause.Image = global::ROE.Templates.Properties.Resources.green_pause_button_md;
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
            this.btnStop.Image = global::ROE.Templates.Properties.Resources.green_stop_button_md;
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
            this.btnPlay.Image = global::ROE.Templates.Properties.Resources.green_play_button_md;
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
            // infoGroup
            // 
            this.infoGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(81)))));
            this.infoGroup.Controls.Add(this.lbSing);
            this.infoGroup.Controls.Add(this.lbAlbum);
            this.infoGroup.Controls.Add(this.lbSong);
            this.infoGroup.Controls.Add(this.picAlbum);
            this.infoGroup.Font = new System.Drawing.Font("AltamonteNF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGroup.Location = new System.Drawing.Point(76, 651);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Size = new System.Drawing.Size(434, 149);
            this.infoGroup.TabIndex = 145;
            this.infoGroup.TabStop = false;
            this.infoGroup.Text = "INFO";
            // 
            // lbSing
            // 
            this.lbSing.AutoSize = true;
            this.lbSing.Font = new System.Drawing.Font("Aklatanic TSO", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSing.ForeColor = System.Drawing.Color.Black;
            this.lbSing.Location = new System.Drawing.Point(165, 69);
            this.lbSing.Name = "lbSing";
            this.lbSing.Size = new System.Drawing.Size(60, 19);
            this.lbSing.TabIndex = 3;
            this.lbSing.Text = "Singer:";
            // 
            // lbAlbum
            // 
            this.lbAlbum.AutoSize = true;
            this.lbAlbum.Font = new System.Drawing.Font("Aklatanic TSO", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlbum.ForeColor = System.Drawing.Color.Black;
            this.lbAlbum.Location = new System.Drawing.Point(165, 101);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(61, 19);
            this.lbAlbum.TabIndex = 2;
            this.lbAlbum.Text = "Album:";
            // 
            // lbSong
            // 
            this.lbSong.AutoSize = true;
            this.lbSong.Font = new System.Drawing.Font("Aklatanic TSO", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSong.ForeColor = System.Drawing.Color.Black;
            this.lbSong.Location = new System.Drawing.Point(165, 38);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(62, 19);
            this.lbSong.TabIndex = 1;
            this.lbSong.Text = "\"Song\"";
            // 
            // picAlbum
            // 
            this.picAlbum.Location = new System.Drawing.Point(10, 23);
            this.picAlbum.Name = "picAlbum";
            this.picAlbum.Size = new System.Drawing.Size(136, 120);
            this.picAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlbum.TabIndex = 0;
            this.picAlbum.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Image = global::ROE.Templates.Properties.Resources.ButtonHelpB1_01;
            this.btnHelp.Location = new System.Drawing.Point(1093, 684);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(130, 116);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHelp.TabIndex = 146;
            this.btnHelp.TabStop = false;
            this.btnHelp.MouseEnter += new System.EventHandler(this.ButtonGUI_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.ButtonGUI_MouseLeave);
            // 
            // progressVideo
            // 
            this.progressVideo.Interval = 1;
            this.progressVideo.Tick += new System.EventHandler(this.progressVideo_Tick);
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
            // B1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(126)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1533, 850);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.infoGroup);
            this.Controls.Add(this.videoGroup);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.topicLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "B1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.videoGroup.ResumeLayout(false);
            this.backgroundVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.infoGroup.ResumeLayout(false);
            this.infoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox videoGroup;
        private System.Windows.Forms.Panel backgroundVideo;
        private AxShockwaveFlashObjects.AxShockwaveFlash videoDisplay;
        private System.Windows.Forms.PictureBox btnBackward;
        private System.Windows.Forms.PictureBox btnForward;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.GroupBox infoGroup;
        protected System.Windows.Forms.Label lbSing;
        protected System.Windows.Forms.Label lbAlbum;
        protected System.Windows.Forms.Label lbSong;
        protected System.Windows.Forms.PictureBox picAlbum;
        protected System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.Timer progressVideo;
        protected System.Windows.Forms.Label topicLabel;
        protected System.Windows.Forms.Label barTitle;
    }
}