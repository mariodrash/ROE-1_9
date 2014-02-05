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
        static string[] resWind1 = { "night", "future", "the moment", "tomorrow", "the past", "the moment", "tomorrow", "time" };
        static string[] resWind2 = { "night", "the moment", "tomorrow", "time", "evening", "time", "tomorrow", "afternoon", "morning", "the moment"};
        static string[] resScientist = { "come", "meet", "tell", "know", "find", "need", "set", "ask", "let", "go", "start", "take", "speak", "love", "haunt" };
        static string[] resWonderful = { };
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

                case "46.0":
                    arrayUtilizado = (string[])resScientist.Clone();
                    break;

                case "56.0":
                    arrayUtilizado = (string[])resWind1.Clone();
                    break;

                case "56.1":
                    arrayUtilizado = (string[])resWind2.Clone();
                    break;

                case "57.0":
                    arrayUtilizado = (string[])resWonderful.Clone();
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

        public static void Evaluate(ComboBox control, int index, ref int score)
        {
            if (control.Text.ToLower() == arrayUtilizado[index])
            {
                control.Enabled = false;
                score += 10;
            }
        }

        public static void EvaluateTextbox(ref TextBox control, int index, ref int score)
        {
            if (control.Text.ToLower() == arrayUtilizado[index])
            {
                control.Enabled = false;
                score += 10;
            }
        }

        public static void ayuda(ref string palabra, int index, ref int ayuda)
        {
            palabra = arrayUtilizado[index];
            ayuda--;
        }
    }
}
