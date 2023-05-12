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

            if (txtCodigoNuevo.Text != "" & txtNombreNuevo.Text != "" & txtTramiteNuevo.Text !="" )
            {

                objNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
                objNodo.Nombre = txtNombreNuevo.Text;
                objNodo.Tramite = txtTramiteNuevo.Text;

                listaDoble.Agregar(objNodo);
                listaDoble.RecorrerASC(grilla);
                listaDoble.RecorrerASC(lstListado);
                listaDoble.RecorrerASC(cboCodigo);
                txtCodigoNuevo.Text = "";
                txtNombreNuevo.Text = "";
                txtTramiteNuevo.Text = "";

                txtCodigoNuevo.Focus();
            }
            else
            {

                MessageBox.Show("Complete los campos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboCodigo.Text != "")
            {
                if (listaDoble.Primero != null)
                {

                    int codigo = Convert.ToInt32(cboCodigo.Text);
                    listaDoble.Eliminar(codigo);
                    listaDoble.RecorrerASC(lstListado);
                    listaDoble.RecorrerASC(cboCodigo);
                    listaDoble.RecorrerASC(grilla);
                }
                else
                {
                    MessageBox.Show("la lista esta vacia ");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un codigo para eliminar");
            }
        }

        private void ListaDoble_Load(object sender, EventArgs e)
        {
            
        }

        private void rboAscendente_CheckedChanged(object sender, EventArgs e)
        {
            listaDoble.RecorrerASC(grilla);
            listaDoble.RecorrerASC(lstListado);
            listaDoble.RecorrerASC(cboCodigo);
        }

        private void rboDescendente_CheckedChanged(object sender, EventArgs e)
        {
            listaDoble.RecorrerDSC(grilla);
            listaDoble.RecorrerDSC(lstListado);
            listaDoble.RecorrerDSC(cboCodigo);
        }

        private void ListaDoble_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
