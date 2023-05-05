using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    class ClsArbolBinario
    {
        ClsNodo inicio;

        public ClsNodo raiz
        {
            get { return inicio; }
            set { inicio = value; }
        }
        public void agregar(ClsNodo nuevo)
        {
            nuevo.izquierda = null;
            nuevo.derecha = null;

            if (raiz==null)
            {
                raiz = nuevo;
            }
            else
            {
                ClsNodo NodoPadre = raiz;
                ClsNodo aux = raiz;
                while (aux !=null)
                {
                    NodoPadre = aux;
                    if (nuevo.Codigo < aux.Codigo)
                    {
                        aux = aux.izquierda;
                    }
                    else
                    {
                        aux = aux.derecha;
                    }
                }
                if (nuevo.Codigo< NodoPadre.Codigo)
                {
                    NodoPadre.izquierda = nuevo;
                }
                else
                {
                    NodoPadre.derecha = nuevo;
                }
            }
        }

        public void RecorrerASC(ListBox lista)
        {
            lista.Items.Clear();
            InOrdenASC(lista, raiz);
            
        } //lista
        public void RecorrerASC(ComboBox combo)
        {
            combo.Items.Clear();
            InOrdenASC(combo, raiz);

        }//combo
        public void RecorrerASC(DataGridView grilla)
        {
            grilla.Rows.Clear();
            InOrdenASC(grilla, raiz);

        }//grilla

        public void RecorrerDSC(ListBox lista)
        {
            lista.Items.Clear();
            InOrdenDSC(lista, raiz);

        } //lista
        public void RecorrerDSC(ComboBox combo)
        {
            combo.Items.Clear();
            InOrdenDSC(combo, raiz);

        }//combo
        public void RecorrerDSC(DataGridView grilla)
        {
            grilla.Rows.Clear();
            InOrdenDSC(grilla, raiz);

        }//grilla

        public void RecorrerPRE(ListBox lista)
        {
            lista.Items.Clear();
            InOrdenPRE(lista, raiz);

        } //lista
        public void RecorrerPRE(ComboBox combo)
        {
            combo.Items.Clear();
            InOrdenPRE(combo, raiz);

        }//combo
        public void RecorrerPRE(DataGridView grilla)
        {
            grilla.Rows.Clear();
            InOrdenPRE(grilla, raiz);

        }//grilla

        public void RecorrerPOST(ListBox lista)
        {
            lista.Items.Clear();
            InOrdenPost(lista, raiz);

        } //lista
        public void RecorrerPOST(ComboBox combo)
        {
            combo.Items.Clear();
            InOrdenPost(combo, raiz);

        }//combo
        public void RecorrerPOST(DataGridView grilla)
        {
            grilla.Rows.Clear();
            InOrdenPost(grilla, raiz);

        }//grilla
        public void InOrdenASC(ListBox lst , ClsNodo R) //lista
        {
            if (R.izquierda != null)
            {
                InOrdenASC(lst, R.izquierda);
            }
            lst.Items.Add(R.Codigo);
            if (R.derecha != null)
            {
                InOrdenASC(lst, R.derecha);
            }
        }
        public void InOrdenASC(ComboBox combo, ClsNodo R) //cpmbo
        {
            if (R.izquierda != null)
            {
                InOrdenASC(combo, R.izquierda);
            }
            combo.Items.Add(R.Codigo);
            if (R.derecha != null)
            {
                InOrdenASC(combo, R.derecha);
            }
        }
        public void InOrdenASC(DataGridView grilla, ClsNodo R) //grilla
        {
            if (R.izquierda != null)
            {
                InOrdenASC(grilla, R.izquierda);
            }
            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.derecha != null)
            {
                InOrdenASC(grilla, R.derecha);
            }
        }
        //public void InOrdenASC(StreamWriter sw, ClsNodo R) //grilla
        //{
            //if (R.izquierda != null)
            //{
            //    InOrdenASC(grilla, R.izquierda);
            //}
            //grilla.Rows.Add(R.Codigo);
            //if (R.derecha != null)
            //{
            //    InOrdenASC(grilla, R.derecha);
            //}
        //}

        public void InOrdenDSC(ListBox lst, ClsNodo R) //lista
        {
            if (R.derecha != null)
            {
                InOrdenDSC(lst, R.derecha);
            }
            lst.Items.Add(R.Codigo);
            if (R.izquierda != null)
            {
                InOrdenDSC(lst, R.izquierda);
            }
        }
        public void InOrdenDSC(ComboBox combo, ClsNodo R) //combo
        {
            if (R.derecha != null)
            {
                InOrdenDSC(combo, R.derecha);
            }
            combo.Items.Add(R.Codigo);
            if (R.izquierda != null)
            {
                InOrdenDSC(combo, R.izquierda);
            }
        }
        public void InOrdenDSC(DataGridView grilla, ClsNodo R) //grilla
        {
            if (R.derecha != null)
            {
                InOrdenDSC(grilla, R.derecha);
            }
            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.izquierda != null)
            {
                InOrdenDSC(grilla, R.izquierda);
            }
        }
        //public void InOrdenDSC(StreamWriter sw, ClsNodo R) 
        //{
            //if (R.derecha != null)
            //{
            //    InOrdenDSC(grilla, R.derecha);
            //}
            //grilla.Rows.Add(R.Codigo);
            //if (R.izquierda != null)
            //{
            //    InOrdenDSC(grilla, R.izquierda);
            //}
        //}//streamWriter


        public void InOrdenPRE(ListBox lst, ClsNodo R)
        {
            lst.Items.Add(R.Codigo);//R
            if (R.izquierda != null)
            {
                InOrdenPRE(lst, R.izquierda);//I
            }
            if (R.derecha != null)
            {
                InOrdenPRE(lst, R.derecha);//D
            }
        } //lista
        public void InOrdenPRE(ComboBox combo, ClsNodo R)
        {
            combo.Items.Add(R.Codigo);//R
            if (R.izquierda != null)
            {
                InOrdenPRE(combo, R.izquierda);//I
            }
            if (R.derecha != null)
            {
                InOrdenPRE(combo, R.derecha);//D
            }
        } //combo
        public void InOrdenPRE(DataGridView grilla, ClsNodo R)
        {
            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);//R
            if (R.izquierda != null)
            {
                InOrdenPRE(grilla, R.izquierda);//I
            }
            if (R.derecha != null)
            {
                InOrdenPRE(grilla, R.derecha);//D
            }
        }//grilla
        //public void InOrdenPRE(StreamWriter sw, ClsNodo R)
        //{
            //grilla.Rows.Add(R.Codigo);//R
            //if (R.izquierda != null)
            //{
            //    InOrdenPRE(grilla, R.izquierda);//I
            //}
            //if (R.derecha != null)
            //{
            //    InOrdenPRE(grilla, R.derecha);//D
            //}
        //}//streamWriter

        public void InOrdenPost(ListBox lst, ClsNodo R)
        {
            
            if (R.izquierda != null)
            {
                InOrdenPost(lst, R.izquierda);//I
            }
            if (R.derecha != null)
            {
                InOrdenPost(lst, R.derecha);//D
            }
            lst.Items.Add(R.Codigo);//R
        } //lista
        public void InOrdenPost( ComboBox combo, ClsNodo R)
        {

            if (R.izquierda != null)
            {
                InOrdenPost(combo, R.izquierda);//I
            }
            if (R.derecha != null)
            {
                InOrdenPost(combo, R.derecha);//D
            }
            combo.Items.Add(R.Codigo);//R
        }//combo
        public void InOrdenPost(DataGridView grilla, ClsNodo R)
        {

            if (R.izquierda != null)
            {
                InOrdenPost(grilla, R.izquierda);//I
            }
            if (R.derecha != null)
            {
                InOrdenPost(grilla, R.derecha);//D
            }
            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);//R
        }//grilla
        //public void InOrdenPost(StreamWriter sw, ClsNodo R)
        //{

            //if (R.izquierda != null)
            //{
            //    InOrdenPost(grilla, R.izquierda);//I
            //}
            //if (R.derecha != null)
            //{
            //    InOrdenPost(grilla, R.derecha);//D
            //}
            //grilla.Rows.Add(R.Codigo);//R
        //}//streamWriter

    }
}
