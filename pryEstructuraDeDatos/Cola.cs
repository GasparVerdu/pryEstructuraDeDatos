using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructuraDeDatos
{
    internal class Cola
    {
        //esta estructura va a estar construida por un conjunto de nodos 

        public Nodo Primero;
        public Nodo Ultimo;

        public void Agregar(Nodo nuevo) 
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                Primero = nuevo;
            }
        }
    }
}
