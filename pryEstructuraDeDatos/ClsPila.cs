using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    class ClsPila
    {
        public ClsNodo primero;

        public void Agregar(ClsNodo Nuevo)
        {
            if (primero == null)
            {
                primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = primero;
                primero = Nuevo;
            }
        }
        public void Eliminar() 
        {
            if (primero!=null)
            {
                primero = primero.Siguiente;
            }
           
        }
        public void Recorrer(DataGridView grilla)
        {
            ClsNodo aux = primero;
            grilla.Rows.Clear();

            while (aux != null)
            {
                grilla.Rows.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ListBox lista)
        {
            ClsNodo aux = primero;
            lista.Items.Clear();

            while (aux != null)
            {
                lista.Items.Add(aux.Codigo + " " + aux.Nombre + "" + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox combo)
        {
            ClsNodo aux = primero;
            combo.Items.Clear();

            while (aux != null)
            {
                combo.Items.Add(aux.Codigo + "" + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }

        }
    }
}
