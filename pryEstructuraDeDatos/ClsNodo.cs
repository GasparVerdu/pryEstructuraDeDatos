using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructuraDeDatos
{
    internal class ClsNodo
    {
        private Int32 Cod;
        private string Nom;
        private string Tra;
        private ClsNodo sig;
        private ClsNodo ant;

        public Int32 Codigo
        {
            //get retorna el dato que esta en cod
            get { return Cod; }
            //set toma el dato 
            set { Cod = value; }
        }

        public String Nombre
        {
            get { return Nom; }
            set { Nom = value; }
        }

        public String Tramite
        {
            get { return Tra; }
            set { Tra = value; }
        }

        public ClsNodo Siguiente 
        {
            get { return sig; } 
            set { sig = value; }
        }

        public ClsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }
    }
}
