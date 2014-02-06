using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ROE.Libraries;
using roe.Utilidades;


namespace ROE.B1
{
    public partial class Boulevard : ROE.Templates.B1
    {
        private ArrayControles<ComboBox> m_comboBoxes;

        public Boulevard()
        {
            InitializeComponent();
            topicLabel.Text = "PREPOSITIONS OF PLACE";
            barTitle.Text = "♫ Boulevard of broken dreams | Green Day ♫";
            
            CenterTopic(topicLabel);
            CenterTopic(barTitle);
            lbSong.Text = "\"Boulevard of broken dreams\"";
            lbSing.Text = "Singer: Green Day";
            lbAlbum.Text = "Album: American Idiot";
            picAlbum.ImageLocation = @"B1/Boulevard/american_idiot.jpg";
        }

        private void Boulevard_Load(object sender, EventArgs e)
        {
            AnswersROE.Id = "1.0";
            score = 0;
            m_comboBoxes = new ArrayControles<ComboBox>("answCombo", this);
            AnswersROE.Revolver();

            for (int i = 0; i < m_comboBoxes.Count; i++)
            {
                string option = AnswersROE.MostrarElemento();
                foreach (var element in m_comboBoxes)
                {
                    element.Items.Add(option);
                }
            }
            
        }

        private void option_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ComboBox evaluated = (ComboBox)sender;
            int idCombo = AnswersROE.ObtenerIndex(evaluated.Name);
            AnswersROE.Evaluate(evaluated, idCombo, ref score);
            if (score == m_comboBoxes.Count * 10)
                MessageBox.Show("");
            //for (int i = 0; i < m_comboBoxes.Count; i++)
            //{

            //}
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            
        }
    }
}
