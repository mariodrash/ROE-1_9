using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROE.A1
{
    class general
    {
        
        public void respuestasBien(ref bool resp)
        {
                if (MessageBox.Show("Your score is Perfect!!!! \n Would you like to try again?", "Congratulations!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    resp = true;
                }
        }

        public void nextActivity(ref int score, ref int help)
        {
            MessageBox.Show("Now do this activity!", "New Activity", MessageBoxButtons.OK, MessageBoxIcon.Information);
            score = 0;
            help = 3;
        }
    }
}
