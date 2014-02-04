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
        string[] respuestas2 = { "night", "the moment", "tomorrow", "time", null, null};
        string[] respuestas3 = { "time", "the moment", "afternoon", "evening", "tomorrow", "morning" };

        public void evaluarPrimero(int x, string palabra, ref bool activar, ref int score)
        {
            if (activar)
            {
                if (palabra.Equals(respuestas2[x]) || palabra.Equals(respuestas3[x]))
                {
                    activar = true;
                    score += 10;
                }
                else
                {
                    activar = false;
                }
            }
            else 
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
            }
        }

        public void ayuda(int x, ref string palabra, ref int help, bool act, bool act2)
        {
            
            if (help != 0)
            {
                if (act)
                {
                    palabra = respuestas1[x];
                }
                else
                {
                    if (act2)
                    {
                        if (x<4)
                        {
                             palabra = respuestas2[x];
                        }
                    }
                    else
                    {
                        palabra = respuestas3[x];
                    }
                }
                help--;
            }
            else
            {
                MessageBox.Show("You have spent all your  clues!!", "INFO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
