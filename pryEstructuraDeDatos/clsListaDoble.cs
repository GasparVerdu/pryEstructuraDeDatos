using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    class clsListaDoble
    {
        private ClsNodo pri;
        private ClsNodo ult;

        public ClsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public ClsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        public void Agregar(ClsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Nuevo.Anterior = Ultimo;
                        Ultimo.Siguiente = Nuevo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        ClsNodo aux = Primero;
                        ClsNodo ant = Primero;
                        while (aux.Codigo < Nuevo.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = aux;
                        aux.Anterior = Nuevo;
                        Nuevo.Anterior = ant;
                    }
                }
            }
        }
        public void Eliminar(Int32 codigo)
        {
            if (Primero.Codigo == codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo == codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        ClsNodo aux = Primero;
                        ClsNodo ant = Primero;
                        while (aux.Codigo < codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }

                        aux = aux.Siguiente;
                        ant.Siguiente = aux;
                        aux.Anterior = ant;

                        //ant.Siguiente = aux.Siguiente;
                        //aux = aux.Siguiente;
                        //aux.Anterior = ant;
                    }
                }
            }
        }

        public void RecorrerASC(DataGridView grilla)
        {
            ClsNodo aux = Primero;
            grilla.Rows.Clear();
            while (aux != null)
            {
                grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void RecorrerASC(ListBox list)
        {
            ClsNodo aux = Primero;
            list.Items.Clear();

            while (aux != null)
            {
                list.Items.Add(aux.Codigo + "" + aux.Nombre + "" + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void RecorrerASC(ComboBox combo)
        {
            ClsNodo aux = Primero;
            combo.Items.Clear();

            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void RecorrerDSC(DataGridView grilla)
        {
            ClsNodo aux = Ultimo;
            grilla.Rows.Clear();
            while (aux != null)
            {
                grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }

        public void RecorrerDSC(ListBox list)
        {
            ClsNodo aux = Ultimo;
            list.Items.Clear();
            while (aux != null)
            {
                list.Items.Add(aux.Codigo + "" + aux.Nombre + "" + aux.Tramite);
                aux = aux.Anterior;
            }
        }
        public void RecorrerDSC(ComboBox combo)
        {
            ClsNodo aux = Ultimo;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Codigo + "" + aux.Nombre + "" + aux.Tramite);
                aux = aux.Anterior;
            }
        }
    }
}
