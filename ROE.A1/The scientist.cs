using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using roe.Utilidades;
using ROE.Templates;

namespace ROE.A1
{
    public partial class The_scientist : ROE.Templates.A1
    {
        public The_scientist()
        {
            InitializeComponent();
            lbTopic.Text = "Present Simple";
            lbTopic.Left = (ClientSize.Width - lbTopic.Width) / 2;
            lbTop.Text = "♫ The Scientist | Coldplay ♫";
            lbTop.Left = (ClientSize.Width - lbTop.Width) / 2;
            lbSing.Text = "Sing: Coldplay";
            lbSong.Text = "\"The scientist\"";
            lbAlbum.Text = "Album: A rush of blood to the head";
            picAlbum.ImageLocation = @"scientist/scientist.jpg";
        }

        private void The_scientist_Load(object sender, EventArgs e)
        {

        }
    }
}
