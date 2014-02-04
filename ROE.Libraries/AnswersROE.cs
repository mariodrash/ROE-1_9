using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROE.Libraries
{
    public static class AnswersROE
    {
        static string[] answer_01 = { "lonely", "empty", "broken", "besides", "down", "between" };
        static string[] arrayUtilizado;
        static string id;
        public static string Id
        {
            get { return id; }
            set
            {
                id = value;
                AsignaArray(id);
            }
        }



        public static void AsignaArray(string identificador)
        {


            switch (identificador)
            {
                case "1.0":
                    arrayUtilizado = (string[])answer_01.Clone();
                    MessageBox.Show(arrayUtilizado[0]);
                    break;
                default:                    
                    break;
            }
        }

        public static int ObtenerIndex(string nameControl)
        {
            string index = string.Empty;
            if (nameControl[nameControl.Length - 2] != 0)
            {
                for (int i = 2; i >= 1; i--)
                {
                    index += nameControl[nameControl.Length - i].ToString();
                }
                return int.Parse(index);
            }
            else
            {
                index = nameControl[nameControl.Length - 1].ToString();
                return int.Parse(index);
            }
        }

        public static void Evaluate(ComboBox control, int index)
        {
            if (control.Text.ToLower() == arrayUtilizado[index])
            {
                control.Enabled = false;
            }
        }
    }
}
