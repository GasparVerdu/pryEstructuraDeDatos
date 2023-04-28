using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void Recorrer(ListBox lista)
        {
            lista.Items.Clear();
            InOrdenASC(lista, raiz);
            
        } 
        public void InOrdenASC(ListBox lst , ClsNodo R)
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
        public void InOrdenDSC(ListBox lst, ClsNodo R)
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
        }

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
        }

    }
}
