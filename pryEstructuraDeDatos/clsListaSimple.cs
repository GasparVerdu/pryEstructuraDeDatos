using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    class clsListaSimple
    {
        public ClsNodo primero;

        public void Agregar(ClsNodo nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;

            }
            else
            {
                if (nuevo.Codigo < primero.Codigo)
                {
                    nuevo.Siguiente = primero;
                    primero = nuevo;
                }
                else
                {
                    ClsNodo aux = primero;
                    ClsNodo ant = primero;

                    while (nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null)
                        {
                            break;
                        }
                    }
                    ant.Siguiente = nuevo;
                    nuevo.Siguiente = aux;
                }
            }
        }
        public void Eliminar(Int32 codigo)
        {
            if (primero.Codigo == codigo )
            {
                primero = primero.Siguiente;
            }
            else
            {
                ClsNodo ant = primero;
                ClsNodo aux = primero;
                while (aux.Codigo != codigo)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                } 
                ant.Siguiente = aux.Siguiente;
            }
        }

        public void Recorrer(DataGridView grilla)
        {
            ClsNodo aux = primero;
            grilla.Rows.Clear();
            while (aux != null)
            {
                grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox list)
        {
            ClsNodo aux = primero;
            list.Items.Clear();

            while (aux != null)
            {
                list.Items.Add(aux.Codigo + "" + aux.Nombre + "" + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox combo)
        {
            ClsNodo aux = primero;
            combo.Items.Clear();

            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
    }
}
