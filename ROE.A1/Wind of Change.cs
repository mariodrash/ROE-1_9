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
        int score = 0, help = 3, veces = 0, sumador = 0;
        private ArrayControles<TextBox>m_Text1;
        private ArrayControles<PictureBox> m_PictureB;
        private ArrayControles<Label> m_Label;
        private ArrayControles<Label> m_Label2;
        private ArrayControles<TextBox> m_Textb2;
        private ArrayControles<TextBox> m_Textb2_2;
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

        private void ayuda(int i, ref string palabra, ref bool act, ref bool act2 )
        {
            classWind set = new classWind();
            set.ayuda(i, ref palabra, ref help, act, act2);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            bool act;
            bool act2 = false;
            if (gbLyrics.Visible)
            {
                act = true;
                for (int i = 0; i < m_Text1.Count; i++)
                {
                    if (m_Text1[i].Text.Equals(string.Empty))
                    {
                        string palabra = null;
                        ayuda(i, ref palabra, ref act, ref act2);
                        m_Text1[i].Text = palabra;
                        break;
                    }
                }
            }
            else
            {
                act = false;
                string palabra = null;
                for (int i = 0; i < m_Textb2_2.Count; i++)
                {
                    if (i < 4)
                    {
                        act2 = true;
                        if (m_Textb2[i].Text.Equals(string.Empty))
                        {
                            ayuda(i, ref palabra, ref act, ref act2);
                            m_Textb2[i].Text = palabra;
                            break;
                        }
                    }
                    if (m_Textb2_2[i].Text.Equals(string.Empty))
                    {
                        for (int s = 0; s < m_PictureB.Count; s++)
                        {
                            if (m_PictureB[i].ImageLocation == @"Wind/wind" + s + ".png")
                            {
                                act2 = false;
                                ayuda(s, ref palabra, ref act, ref act2);
                                m_Textb2_2[i].Text = palabra;
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }

        private void aleatorio()
        {
            label14.Text = "" + veces++;
            Random ran = new Random();
            int cargar = ran.Next(6);
            if (sumador < m_PictureB.Count)
            {
                Random(cargar);
            }
        }

        private void Random(int cargar)
        {
            label14.Text = "" + veces++;
            bool act = false;
            for (int i = 0; i < m_PictureB.Count; i++)
            {
                if ((m_PictureB[i].ImageLocation == @"Wind/wind" + cargar + ".png"))
                {
                    aleatorio();
                    act = true;
                    break;
                }
            }
            if (m_PictureB[sumador].ImageLocation == null && act.Equals(false))
            {
                m_PictureB[sumador].ImageLocation = @"Wind/wind" + cargar + ".png";
                sumador++;
                if (sumador.Equals(6))
                {
                    sumador = 0;
                }
                else
                {
                    aleatorio();
                }
            }
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
                        m_Text1[i].BackColor = Color.YellowGreen;
                        m_Text1[i].ForeColor = Color.Black;
                        m_Text1[i].Enabled = false;
                    }
                    else
                    {
                        m_Text1[i].BackColor = Color.IndianRed;
                        m_Text1[i].ForeColor = Color.White;
                    }
                    break;
                }
            }
            if (score.Equals(80))
            {
                general set = new general();
                set.nextActivity(ref score, ref help);
                gbLyrics.Hide();
                gbActivity.Show();
                lbDirections.Text = "Match the words in gray with the correct definition and with the correct picture";
                lbDirections.Left = (panel7.Width - lbDirections.Width) / 2;
            }
        }

        private void TextBox_Textchanged2(object sender, EventArgs e)
        {
            TextBox objeto = (TextBox)sender;
            for (int i = 0; i < m_Textb2_2.Count; i++)
            {
                if ( i< 4)
                {
                    if (objeto.Name.Equals(m_Textb2[i].Name))
                    {
                        int x = i;
                        string palabra = m_Textb2[i].Text.ToLower();
                        bool bien = true;

                        classWind set = new classWind();
                        set.evaluarPrimero(x, palabra, ref bien, ref score);
                        if (bien)
                        {
                            m_Textb2[i].BackColor = Color.YellowGreen;
                            m_Textb2[i].ForeColor = Color.Black;
                            m_Textb2[i].Enabled = false;
                        }
                        else
                        {
                            m_Textb2[i].BackColor = Color.IndianRed;
                            m_Textb2[i].ForeColor = Color.White;
                        }
                        break;
                    }
                }
                if (objeto.Name.Equals(m_Textb2_2[i].Name) )
                {
                    int x = i;
                    string palabra = m_Textb2_2[i].Text.ToLower();
                    bool bien = true;
                    for (int s = 0; s < m_PictureB.Count; s++)
                    {
                        if (m_PictureB[i].ImageLocation == @"Wind/wind" + s + ".png")
                        {
                            classWind set = new classWind();
                            set.evaluarPrimero(s, palabra, ref bien, ref score);
                            if (bien)
                            {
                                m_Textb2_2[i].BackColor = Color.YellowGreen;
                                m_Textb2_2[i].ForeColor = Color.Black;
                                m_Textb2_2[i].Enabled = false;
                            }
                            else
                            {
                                m_Textb2_2[i].BackColor = Color.IndianRed;
                                m_Textb2_2[i].ForeColor = Color.White;
                            }
                            break;
                        }
                    }
                }

            }

            if (score.Equals(100))
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

        private void Wind_of_Change_Load(object sender, EventArgs e)
        {
            m_Text1 = new ArrayControles<TextBox>("textBox", this);
            m_PictureB = new ArrayControles<PictureBox>("Picture2B", this);
            m_Label = new ArrayControles<Label>("Lab1", this);
            m_Label2 = new ArrayControles<Label>("Lab2", this);
            m_Textb2 = new ArrayControles<TextBox>("Textb2", this);
            m_Textb2_2 = new ArrayControles<TextBox>("Text2B", this);
            label14.Hide();
            gbActivity.Hide();
            timer1.Start();
            aleatorio();
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
    }
}
