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
        string Nombre;
        string Tramite;

        private ClsNodo[] vector = new ClsNodo[100];
        private Int32 indice = 0;
        public ClsNodo raiz
        {
            get { return inicio; }
            set { inicio = value; }
        }
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string tramite
        {
            get { return Tramite; }
            set { Tramite = value; }
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

        public void Eliminar(Int32 Codigo)
        {
            if (raiz!= null)
            {
                ClsNodo RaizBuscar = raiz;
                ClsNodo Auxiliar = null;

                while (RaizBuscar.Codigo != Codigo)
                {
                    if (Codigo < RaizBuscar.Codigo)
                    {
                        Auxiliar = RaizBuscar;
                        RaizBuscar = RaizBuscar.izquierda;
                    }
                    else
                    {
                        Auxiliar = RaizBuscar;
                        RaizBuscar = RaizBuscar.derecha;
                    }
                }
                if (RaizBuscar.Codigo == Codigo)
                {
                    if (RaizBuscar.izquierda == null && RaizBuscar.derecha == null)
                    {
                        if (Auxiliar == null)
                        {
                            raiz = null;
                            return;
                        }
                        if (Auxiliar.izquierda == RaizBuscar)
                        {
                            Auxiliar.izquierda = null;
                            return;
                        }
                        else
                        {
                            Auxiliar.derecha = null;
                        }
                    }
                    if (RaizBuscar.izquierda == null)
                    {
                        if (Auxiliar == null)
                        {
                            raiz = RaizBuscar.derecha;
                        }
                        if (Auxiliar.izquierda == RaizBuscar)
                        {
                            Auxiliar.izquierda = RaizBuscar.derecha;
                        }
                        else
                        {
                            Auxiliar.derecha = RaizBuscar.derecha;
                        }
                    }
                    if (RaizBuscar.derecha == null)
                    {
                        if (Auxiliar == null)
                        {
                            raiz = RaizBuscar.izquierda;
                            return;
                        }
                        if (Auxiliar.izquierda == RaizBuscar)
                        {
                            Auxiliar.izquierda = RaizBuscar.izquierda;
                        }
                        else
                        {
                            Auxiliar.derecha = RaizBuscar.izquierda;
                        }
                    }
                    if (RaizBuscar.izquierda != null && RaizBuscar.derecha != null)
                    {
                        ClsNodo Reemplazo = RaizBuscar.derecha;
                        ClsNodo AuxReemplazo = RaizBuscar;
                        while (Reemplazo.izquierda != null)
                        {
                            AuxReemplazo = Reemplazo;
                            Reemplazo = Reemplazo.izquierda;
                        }

                        RaizBuscar.Codigo = Reemplazo.Codigo;
                        RaizBuscar.Nombre = Reemplazo.Nombre;
                        RaizBuscar.Tramite = Reemplazo.Tramite;
                        if (AuxReemplazo == RaizBuscar)
                        {
                            AuxReemplazo.derecha = Reemplazo.derecha;
                        }
                        else
                        {
                            AuxReemplazo.izquierda = Reemplazo.derecha;
                        }
                    }
                }
            }
            
        }


        public void CargarVector(ClsNodo NodoPadre)
        {
            if (NodoPadre.izquierda == null)
            {
                CargarVector(NodoPadre.izquierda);
            }
            vector[indice] = NodoPadre;
            indice = indice + 1;
            if (NodoPadre.derecha == null)
            {
                CargarVector(NodoPadre.derecha);
            }
        }

        public void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                agregar(vector[m]);
                EquilibrarArbol(ini, m + 1);
                EquilibrarArbol(m + 1, fin);
            }
        }
        public void Equilibrar()
        {
            indice = 0;
            CargarVector(raiz);
            raiz = null;
            EquilibrarArbol(0, indice -1);

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
            OrdenPRE(lista, raiz);

        } //lista
        public void RecorrerPRE(ComboBox combo)
        {
            combo.Items.Clear();
            OrdenPRE(combo, raiz);

        }//combo
        public void RecorrerPRE(DataGridView grilla)
        {
            grilla.Rows.Clear();
            OrdenPRE(grilla, raiz);

        }//grilla

        public void RecorrerPOST(ListBox lista)
        {
            lista.Items.Clear();
            OrdenPost(lista, raiz);

        } //lista
        public void RecorrerPOST(ComboBox combo)
        {
            combo.Items.Clear();
            OrdenPost(combo, raiz);

        }//combo
        public void RecorrerPOST(DataGridView grilla)
        {
            grilla.Rows.Clear();
            OrdenPost(grilla, raiz);

        }//grilla
        public void InOrdenASC(ListBox lst , ClsNodo R) //lista
        {
            if (R.izquierda != null)
            {
                InOrdenASC(lst, R.izquierda);
            }
            lst.Items.Add(R.Codigo + "" + R.Nombre + "" + R.Tramite);
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
        
        //}
        //}

        public void InOrdenDSC(ListBox lst, ClsNodo R) //lista
        {
            if (R.derecha != null)
            {
                InOrdenDSC(lst, R.derecha);
            }
            lst.Items.Add(R.Codigo + "" + R.Nombre + "" + R.Tramite);
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
            
        //}//streamWriter


        public void OrdenPRE(ListBox lst, ClsNodo R)
        {
            lst.Items.Add(R.Codigo + "" + R.Nombre + "" + R.Tramite);//R
            if (R.izquierda != null)
            {
                OrdenPRE(lst, R.izquierda);//I
            }
            if (R.derecha != null)
            {
                OrdenPRE(lst, R.derecha);//D
            }
        } //lista
        public void OrdenPRE(ComboBox combo, ClsNodo R)
        {
            combo.Items.Add(R.Codigo);//R
            if (R.izquierda != null)
            {
                OrdenPRE(combo, R.izquierda);//I
            }
            if (R.derecha != null)
            {
                OrdenPRE(combo, R.derecha);//D
            }
        } //combo
        public void OrdenPRE(DataGridView grilla, ClsNodo R)
        {
            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);//R
            if (R.izquierda != null)
            {
                OrdenPRE(grilla, R.izquierda);//I
            }
            if (R.derecha != null)
            {
                OrdenPRE(grilla, R.derecha);//D
            }
        }//grilla
         //public void OrdenPRE(StreamWriter sw, ClsNodo R)
         //{
         
         //}
         //}//streamWriter

        public void OrdenPost(ListBox lst, ClsNodo R)
        {
            
            if (R.izquierda != null)
            {
                OrdenPost(lst, R.izquierda);//I
            }
            if (R.derecha != null)
            {
                OrdenPost(lst, R.derecha);//D
            }
            lst.Items.Add(R.Codigo + "" + R.Nombre + "" + R.Tramite);//R
        } //lista
        public void OrdenPost( ComboBox combo, ClsNodo R)
        {

            if (R.izquierda != null)
            {
                OrdenPost(combo, R.izquierda);//I
            }
            if (R.derecha != null)
            {
                OrdenPost(combo, R.derecha);//D
            }
            combo.Items.Add(R.Codigo);//R
        }//combo
        public void OrdenPost(DataGridView grilla, ClsNodo R)
        {

            if (R.izquierda != null)
            {
                OrdenPost(grilla, R.izquierda);//I
            }
            if (R.derecha != null)
            {
                OrdenPost(grilla, R.derecha);//D
            }
            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);//R
        }//grilla
         //public void OrdenPost(StreamWriter sw, ClsNodo R)
         //{

        //}//streamWriter
        public void OrdenPRE(TreeNodeCollection NodoPadreTV, ClsNodo nodoR)
        {
            TreeNode NuevoNodo = NodoPadreTV.Add(nodoR.Codigo.ToString());
            if (nodoR.izquierda != null)
            {
                OrdenPRE(NuevoNodo.Nodes, nodoR.izquierda);

            }
            if (nodoR.derecha != null)
            {
                OrdenPRE(NuevoNodo.Nodes, nodoR.derecha);
            }
        }
        public void RecorrerPRE(TreeView arbol)
        {
            arbol.Nodes.Clear();
            OrdenPRE(arbol.Nodes, raiz);
        }
        public ClsNodo cmdBuscar(Int32 parCodigo)
        {
            ClsNodo aux = raiz;
            while (aux != null)
            {
                if (parCodigo == aux.Codigo) break;
                if (parCodigo < aux.Codigo) aux = aux.izquierda;
                else aux = aux.derecha;
            }

            return aux;
        }
    }
}
