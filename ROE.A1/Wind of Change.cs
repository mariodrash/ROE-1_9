using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ROE.Templates;
using roe.Utilidades;

namespace ROE.A1
{
    public partial class Wind_of_Change : ROE.Templates.A1
    {
       
        private string pathReproducir = Application.StartupPath + "/Wind";
        bool activar = false;
        int score = 0;
        private ArrayControles<TextBox>m_Text1;
        public Wind_of_Change()
        {
            InitializeComponent();
            lbTopic.Text = "Time";
            lbTop.Text = "♫ Wind Of Change | Scorpions ♫";
            lbTop.Left = (ClientSize.Width - lbTop.Width) / 2;
            lbTopic.Left = (ClientSize.Width - lbTopic.Width) / 2;
            lbAlbum.Text = "Album: Crazy World";
            lbSing.Text = "Singer: Scorpions";
            lbSong.Text = "\"Wind of change\"";
            lbDirections.Text = "Listen to the song and complete the missing words";
            lbDirections.Left = (panel7.Width - lbDirections.Width) / 2;
            PathVideo = "/Wind/Wind.swf";
            picAlbum.ImageLocation = @"Wind/Wind.jpg";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            general eva = new general();
            activar = true;
            eva.respuestasBien(activar);
        }

        private void TextBox_Textchanged(object sender, EventArgs e)
        {
            TextBox objeto = (TextBox)sender;
            for (int i = 0; i < m_Text1.Count; i++)
            {
                if (objeto.Name.Equals(m_Text1[i].Name))
                {
                    int x = i;
                    string palabra = m_Text1[i].Text.ToLower();
                    bool bien = false;
                    classWind set = new classWind();
                    set.evaluarPrimero(x,palabra, ref bien, ref score);
                    if (bien)
                    {
                        m_Text1[i].BackColor = Color.Green;
                    }
                    else
                    {
                        m_Text1[i].BackColor = Color.Red;
                    }
                    break;
                }
            }
        }

        private void Wind_of_Change_Load(object sender, EventArgs e)
        {
            m_Text1 = new ArrayControles<TextBox>("textBox", this);
        }
    }
}
