using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    public partial class ListaDoble : Form
    {
        public ListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble listaDoble = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo objNodo = new ClsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            objNodo.Nombre = txtNombreNuevo.Text;
            objNodo.Tramite = txtTramiteNuevo.Text;

            listaDoble.Agregar(objNodo);
            listaDoble.Recorrer(grilla);
            listaDoble.Recorrer(lstListado);
            listaDoble.Recorrer(cboCodigo);
            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramiteNuevo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listaDoble.Primero != null)
            {
                int codigo = Convert.ToInt32(cboCodigo.Text);
                listaDoble.Eliminar(codigo);
                listaDoble.Recorrer(lstListado);
                listaDoble.Recorrer(cboCodigo);
                listaDoble.Recorrer(grilla);
            }
            else
            {
                MessageBox.Show("la lista esta vacia ");
            }
        }

        private void ListaDoble_Load(object sender, EventArgs e)
        {

        }
    }
}
