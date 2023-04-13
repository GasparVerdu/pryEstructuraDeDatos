using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    internal class ClsCola
    {
        //esta estructura va a estar construida por un conjunto de nodos 

        public ClsNodo Primero;
        public ClsNodo Ultimo;

        public void Agregar(ClsNodo nuevo) 
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                Ultimo  = nuevo;
            }
        }
        public void Eliminar()
        {
            //si primero y ultimo son iguales queda vacio 
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }

        public void Recorrer(DataGridView grilla)
        {
            ClsNodo aux = Primero;
            grilla.Rows.Clear();
            while (aux != null)
            {
                grilla.Rows.Add(aux.Codigo,aux.Nombre ,aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox list)
        {
            ClsNodo aux = Primero;
            list.Items.Clear();

            while (aux != null)
            {
                list.Items.Add(aux.Codigo + "" + aux.Nombre + "" + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox combo)
        {
            ClsNodo aux = Primero;
            combo.Items.Clear();

            while (aux != null)
            {
                combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
        public void Listar()
        {

        }
    }
}
