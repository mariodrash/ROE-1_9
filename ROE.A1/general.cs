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
        
        public void respuestasBien(bool activador)
        {
            if (activador)
            {
                if (MessageBox.Show("Your score is Perfect!!!! \n Would you like to try again?", "Congratulations!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("Your score is \n Try again", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void nextActivity()
        {
            MessageBox.Show("Now do this activity!", "New Activity", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
