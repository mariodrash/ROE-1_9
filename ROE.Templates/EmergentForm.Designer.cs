namespace ROE.Templates
{
    partial class EmergentForm
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
            this.SuspendLayout();
            // 
            // EmergentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 133);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmergentForm";
            this.Text = "EmergentForm";
            this.Load += new System.EventHandler(this.EmergentForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EmergentForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmergentForm_MouseDown);
            this.MouseEnter += new System.EventHandler(this.EmergentForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.EmergentForm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmergentForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}