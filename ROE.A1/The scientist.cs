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
using ROE.Libraries;

namespace ROE.A1
{
    public partial class The_scientist : ROE.Templates.A1
    {
        private ArrayControles<ComboBox> m_Combo;
        int score = 0, help = 3;
        public The_scientist()
        {
            InitializeComponent();
            lbTopic.Text = "Present Simple";
            lbTopic.Left = (ClientSize.Width - lbTopic.Width) / 2;
            lbTop.Text = "♫ The Scientist | Coldplay ♫";
            lbTop.Left = (ClientSize.Width - lbTop.Width) / 2;
            lbSing.Text = "Singer: Coldplay";
            lbSong.Text = "\"The scientist\"";
            lbAlbum.Text = "Album: A rush of blood to the head";
            picAlbum.ImageLocation = @"scientist/scientist.jpg";
        }

        private void The_scientist_Load(object sender, EventArgs e)
        {
            m_Combo = new ArrayControles<ComboBox>("Combo", this);
            AnswersROE.Id = "46.0";
            gbActivity.Hide();
        }

        private void option_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox evaluated = (ComboBox)sender;
            int idCombo = AnswersROE.ObtenerIndex(evaluated.Name);
            AnswersROE.Evaluate(evaluated, idCombo, ref score);
            calificar();
        }

        private void calificar()
        {
            label4.Text = Convert.ToString(score*100/150);
            if (score.Equals(150) && gbLyrics.Visible)
            {
                general set = new general();
                set.nextActivity(ref score, ref help);
                gbLyrics.Hide();
                gbActivity.Show();
                lbDirections.Text = "";
                lbDirections.Left = (panel7.Width - lbDirections.Width) / 2;
                AnswersROE.Id = "46.1";
            }
            else if (score == 160)
            {
                bool resp = false;
                general set = new general();
                set.respuestasBien(ref resp);
                if (resp)
                {
                    The_scientist again = new The_scientist();
                    again.Show();
                    this.Hide();
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string palabra = null;
            if (gbLyrics.Visible)
            {
                for (int i = 0; i < m_Combo.Count; i++)
                {
                    if (m_Combo[i].Enabled)
                    {
                        AnswersROE.ayuda(ref palabra, i, ref help);
                        m_Combo[i].Text = palabra;
                        break;
                    }
                }
            }
        }
    }
}
