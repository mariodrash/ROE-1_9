using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROE.A1
{
    class classWind
    {
        string[] respuestas1 = { "night", "future", "the moment", "tomorrow", "the past", "the moment", "tomorrow", "time" };


        public void evaluarPrimero(int x, string palabra, ref bool activar, ref int score)
        {
            if (palabra.Equals(respuestas1[x]))
            {
                activar = true;
                score += 10;
            }
            else
            {
                activar = false;
            }

            if (score.Equals(80))
            {
                 MessageBox.Show("Now do this activity!", "New Activity", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
