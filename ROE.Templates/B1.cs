using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROE.Templates
{
    public partial class B1 : Form
    {
        private string videoPath;
        private int idActividad;

        //Property to set or get the current video path.
        public string VideoPath
        {
            get { return videoPath; }
            set { videoPath = value; }
        }
        private bool forward, rewind;
        protected int help, activity;
        protected int _id;

        
        

        public B1()
        {
            InitializeComponent();
        }

        //Method which will be used in order to stop the video timer.
        private void DetenerTimerReproductor()
        {
            forward = false;
            rewind = false;
            progressVideo.Stop();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //videoDisplay.LoadMovie(0, Application.StartupPath + VideoPath);
            DetenerTimerReproductor();
            videoDisplay.Play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DetenerTimerReproductor();
            videoDisplay.Rewind();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            rewind = true;
            forward = false;
            progressVideo.Start();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            forward = true;
            rewind = false;
            progressVideo.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            DetenerTimerReproductor();
            videoDisplay.StopPlay();
        }

        private void progressVideo_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                if (rewind)
                    videoDisplay.Back();
                else
                    videoDisplay.Forward();
            }
        }

        private void ButtonGUI_MouseEnter(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
            if (button.Name == "btnHelp")
                button.ImageLocation = @"B1_GUI/ButtonHelpB1_On-01.png";

            button.Height += 10;
            button.Width += 10;
        }

        private void ButtonGUI_MouseLeave(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
            if (button.Name == "btnHelp")
                button.ImageLocation = @"B1_GUI/ButtonHelpB1-01.png";

            button.Width -= 10;
            button.Height -= 10;
        }

        protected void CenterTopic(Label etiqueta)
        {
            etiqueta.Location = new Point((this.ClientSize.Width - etiqueta.Width) / 2, etiqueta.Location.Y);
        }

        

    }
}
