using System;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Drawing;

namespace roe.Utilidades
{
    class ArrayControles<T> : List<T>
        where T : Control
    {
        private string m_Nombre;

        //El constructor inicializa el nombre de m_Nombre
        public ArrayControles(string elNombre)
            : base()
        {
            if (String.IsNullOrEmpty(elNombre))
            {
                throw new ArgumentException("El nombre del control no puede ser una cadena vacía");
            }

            this.Nombre = elNombre;
        }

        public ArrayControles(string elNombre, Control.ControlCollection ctrls)
            : this(elNombre)
        {
            this.Clear();
            asignarLosControles(ctrls);
            this.Reorganizar();
        }

        public ArrayControles(string elNombre, ContainerControl contenedor)
            : this(elNombre, contenedor.Controls)
        {
            
        }

        public void AsignarControles(ContainerControl contenedor)
        {
            this.Clear();
            asignarLosControles(contenedor.Controls);
            this.Reorganizar();
        }

        private void asignarLosControles(Control.ControlCollection ctrls)
        {
            //El tip debe de ser de Control, para tener en cuenta todos los controles que haya en la colección indicada
            foreach (Control ctr in ctrls)
            {
                //Hacer una llamada recursiva por si este control "contiene" otros
                if (ctr.Controls.Count > 0)
                {
                    asignarLosControles(ctr.Controls);
                }

                //No tener en cuenta las mayusculas o minúsculas
                if (ctr.Name.ToLower().IndexOf(m_Nombre) > -1)
                {
                    this.Add(ctr as T);
                }
            }
        }

        public T this[string name]
        {
            get
            {
                int index = this.Index(name);
                //Si existe, devolverlo, sino, devolver el valor nulo
                if (index == 1)
                {
                    return null;
                }

                return this[index];
            }
        }

        public T this[object obj]
        {
            get
            {
                if (obj.GetType() == typeof(int))
                {
                    return base[(int)obj];
                }

                T ctrl = obj as T;
                return ctrl;
            }
        }

        public int Index(object obj)
        {
            Control ctrl = obj as Control;
            if (ctrl == null)
            {
                return -1;
            }

            int i = -1;
            i = ctrl.Name.LastIndexOf("_");
            if (i > -1)
            {
                i = Convert.ToInt32(ctrl.Name.Substring(i+1));
            }

            return i;
        }

        public int Index(string name)
        {
            int hallado = -1;
            for (int i = 0; i < this.Count; i++)
            {
                T ctrl = this[i];
                if (String.Compare(ctrl.Name,name,true)== 0)
                {
                    hallado = i;
                    break;
                }
            }

            return hallado;
        }

        public int Index(T ctrl)
        {
            int i = ctrl.Name.LastIndexOf("_");

            //Si el nombre no tiene el signo _
            if (i == -1)
            {
                i = this.IndexOf(ctrl);
            }

            else
            {
                i = Convert.ToInt32(ctrl.Name.Substring(i+1));
            }

            return i;
        }

        //La propiedad Nombre sera externamente solo de lectura, por eso private set
        public string Nombre
        {
            get
            {
                return m_Nombre;
            }

            private set
            {
                m_Nombre = value.ToLower();
            }
        }

        //Reorganizar el contenido de la colección, ordenando por el índice indicado después del guión bajo

        public void Reorganizar()
        {
            List<T> ca = new List<T>();
            for (int i = 0; i < this.Count; i++)
            {
                foreach (T ctr in this)
                {
                    if (i == this.Index(ctr))
                    {
                        ca.Add(ctr);
                        break;

                    }
                }
            }
            this.Clear();
            foreach (T ctr in ca)
            {
                this.Add(ctr);
            }
        }

    }
}
