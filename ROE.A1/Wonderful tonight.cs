using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROE.A1
{
    public partial class Wonderful_tonight : ROE.Templates.A1
    {
        public Wonderful_tonight()
        {
            InitializeComponent();
            lbAlbum.Text = "Album: Slowhand";
            lbSing.Text = "Singer: Eric Clapton";
            lbSong.Text = "\"Wonderful tonight\"";
            lbTop.Text = "♫ Wonderful Tonight | Eric Clapton ♫";
            lbTop.Left = (ClientSize.Width - lbTop.Width) / 2;
            lbTopic.Text = "Present Simple";
            lbTopic.Left = (ClientSize.Width - lbTopic.Width) / 2;
            picAlbum.ImageLocation = @"wonderful/wonderful.jpg";
        }
    }
}
