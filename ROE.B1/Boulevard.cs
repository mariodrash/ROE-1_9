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


namespace ROE.B1
{
    public partial class Boulevard : ROE.Templates.B1
    {
        int score = 0;
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
        }

        private void option_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox evaluated = (ComboBox)sender;
            int idCombo = AnswersROE.ObtenerIndex(evaluated.Name);
            AnswersROE.Evaluate(evaluated, idCombo, ref score);
        }
    }
}
