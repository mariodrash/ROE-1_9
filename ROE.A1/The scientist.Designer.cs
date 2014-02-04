namespace ROE.A1
{
    partial class The_scientist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(The_scientist));
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbDirections = new System.Windows.Forms.Label();
            this.gbLyrics = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            this.panel7.SuspendLayout();
            this.gbLyrics.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbDirections);
            this.panel7.Location = new System.Drawing.Point(592, 93);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(920, 35);
            this.panel7.TabIndex = 156;
            // 
            // lbDirections
            // 
            this.lbDirections.AutoSize = true;
            this.lbDirections.Font = new System.Drawing.Font("Segoe Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDirections.ForeColor = System.Drawing.Color.White;
            this.lbDirections.Location = new System.Drawing.Point(255, 11);
            this.lbDirections.Name = "lbDirections";
            this.lbDirections.Size = new System.Drawing.Size(81, 22);
            this.lbDirections.TabIndex = 153;
            this.lbDirections.Text = "Directions";
            // 
            // gbLyrics
            // 
            this.gbLyrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(149)))), ((int)(((byte)(201)))));
            this.gbLyrics.Controls.Add(this.label3);
            this.gbLyrics.Controls.Add(this.panel3);
            this.gbLyrics.Controls.Add(this.label2);
            this.gbLyrics.Controls.Add(this.label1);
            this.gbLyrics.Font = new System.Drawing.Font("AltamonteNF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLyrics.Location = new System.Drawing.Point(592, 129);
            this.gbLyrics.Name = "gbLyrics";
            this.gbLyrics.Size = new System.Drawing.Size(920, 508);
            this.gbLyrics.TabIndex = 155;
            this.gbLyrics.TabStop = false;
            this.gbLyrics.Text = "Lyrics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aklatanic TSO", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 380);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aklatanic TSO", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 380);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(68)))), ((int)(((byte)(166)))));
            this.panel3.Location = new System.Drawing.Point(59, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(811, 75);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(38, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "1.-";
            // 
            // The_scientist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 850);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.gbLyrics);
            this.Name = "The_scientist";
            this.Text = "The_scientist";
            this.Load += new System.EventHandler(this.The_scientist_Load);
            this.Controls.SetChildIndex(this.lbTopic, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.gbLyrics, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.gbLyrics.ResumeLayout(false);
            this.gbLyrics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbDirections;
        private System.Windows.Forms.GroupBox gbLyrics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}