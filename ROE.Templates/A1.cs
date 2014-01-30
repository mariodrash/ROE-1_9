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
    public partial class A1 : Form
    {
        bool forward = false, backward = false;
        private string pathReproducir;
        public string PathVideo
        {
            get { return pathReproducir; }
            set { pathReproducir = value; }
        }

        public A1()
        {
            InitializeComponent();
            string video = Application.StartupPath;
            lbTop.Left = (ClientSize.Width - lbTop.Width) / 2;
            lbTopic.Left = (ClientSize.Width - lbTopic.Width) / 2;
        }

        private void ForwardBackwardMetodo()
        {
            backward = false;
            forward = false;
            BackwardForward.Stop();
        }

        private void objeto_MouseEnter(object sender, EventArgs e)
        {
            PictureBox objeto = (PictureBox)sender;
            objeto.Height += 10;
            objeto.Width += 10;
            if (objeto.Name.Equals("btnHelp"))
            {
                objeto.ImageLocation = @"ButtonA1_On-01.png";
            }
        }

        private void objeto_MouseLeave(object sender, EventArgs e)
        {
            PictureBox objeto = (PictureBox)sender;
            objeto.Height -= 10;
            objeto.Width -= 10;
            if (objeto.Name.Equals("btnHelp"))
            {
                objeto.ImageLocation = @"ButtonHelpA1_01.png";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Rewind();
            ForwardBackwardMetodo();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            backward = true;
            forward = false;
            BackwardForward.Start();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.LoadMovie(0, Application.StartupPath + PathVideo);
            axShockwaveFlash1.Play();
            ForwardBackwardMetodo();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            forward = true;
            backward = false;
            BackwardForward.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.StopPlay();
            ForwardBackwardMetodo();
        }

        private void BackwardForward_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                if (backward)
                {
                    this.axShockwaveFlash1.Back();
                }
                else if (forward)
                {
                    this.axShockwaveFlash1.Forward();
                }
            }
        }
    }
}
