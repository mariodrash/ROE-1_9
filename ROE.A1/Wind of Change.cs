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
using ROE.Libraries;

namespace ROE.A1
{
    public partial class Wind_of_Change : ROE.Templates.A1
    {
       
        private string pathReproducir = Application.StartupPath + "/Wind";
        int score = 0, help = 3;
        private ArrayControles<TextBox>m_Text1;
        private ArrayControles<TextBox> m_Textb2;
        private ArrayControles<Label> m_Label1;
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

        private void calificar(TextBox evaluated)
        {
            if (evaluated.Enabled)
            {
                evaluated.BackColor = Color.IndianRed;
                evaluated.ForeColor = Color.White;
            }
            else
            {
                evaluated.BackColor = Color.YellowGreen;
                evaluated.ForeColor = Color.Black;
            }
            if (score.Equals(80) && gbLyrics.Visible)
            {
                general set = new general();
                set.nextActivity(ref score, ref help);
                gbLyrics.Hide();
                gbActivity.Show();
                lbDirections.Text = "Match the words with the correct definition and with the correct picture";
                lbDirections.Left = (panel7.Width - lbDirections.Width) / 2;
                AnswersROE.Id = "56.1";
            }
            else if (score.Equals(100))
            {
                bool resp = false;
                general set = new general();
                set.respuestasBien(ref resp);
                if (resp)
                {
                    Wind_of_Change again = new Wind_of_Change();
                    again.Show();
                    this.Hide();
                }
            }
        }

        private void hideLabel()
        {
            for (int i = 0; i < m_Textb2.Count; i++)
            {
                if (m_Textb2[i].Enabled.Equals(false) && m_Label1[i].Visible)
                {
                    m_Label1[i].Hide();
                    break;
                }
            }
        }

        private void option_TextChanged(object sender, EventArgs e)
        {
            TextBox evaluated = (TextBox)sender;
            int idText = AnswersROE.ObtenerIndex(evaluated.Name);
            AnswersROE.EvaluateTextbox(ref evaluated, idText, ref score);
            calificar(evaluated);
            hideLabel();
           
        }

        private void Wind_of_Change_Load(object sender, EventArgs e)
        {
            AnswersROE.Id = "56.0";
            m_Text1 = new ArrayControles<TextBox>("textBox", this);
            m_Textb2 = new ArrayControles<TextBox>("TextB2", this);
            m_Label1 = new ArrayControles<Label>("Labe2", this);
            label14.Hide();
            gbActivity.Hide();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gbLyrics.Visible)
            {
                if (lbDirections.ForeColor == Color.White)
                {
                    lbDirections.ForeColor = Color.Black;
                }
                else
                {
                    lbDirections.ForeColor = Color.White;
                }
            }
            else
            {
                if (lbDirections.ForeColor == Color.White)
                {
                    lbDirections.ForeColor = Color.Chartreuse;
                }
                else
                {
                    lbDirections.ForeColor = Color.White;
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string palabra = null;
            if (gbLyrics.Visible)
            {
                for (int i = 0; i < m_Text1.Count; i++)
                {
                    if (m_Text1[i].BackColor != Color.YellowGreen)
                    {
                        AnswersROE.ayuda(ref palabra, i, ref help);
                        m_Text1[i].Text = palabra;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < m_Textb2.Count; i++)
                {
                    if (m_Textb2[i].BackColor != Color.YellowGreen)
                    {
                        AnswersROE.ayuda(ref palabra, i, ref help);
                        m_Textb2[i].Text = palabra;
                        break;
                    }
                }
            }
        }
    }
}
