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
    public partial class FrmColas : Form
    {
        
        public FrmColas()
        {
            InitializeComponent();
        }

        ClsCola FilaDePersonas = new ClsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo objNodo = new ClsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            objNodo.Nombre = txtNombreNuevo.Text;
            objNodo.Tramite = txtTramiteNuevo.Text;

            FilaDePersonas.Agregar(objNodo);
            FilaDePersonas.Recorrer(grilla);
            FilaDePersonas.Recorrer(lstListado);
            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramiteNuevo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                lblCodigoEliminarRes.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNombreEliminarRes.Text = FilaDePersonas.Primero.Nombre;
                lblTramiteEliminarRes.Text = FilaDePersonas.Primero.Tramite;

                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(grilla);
                FilaDePersonas.Recorrer(lstListado);
            }
            else
            {
                lblCodigoEliminarRes.Text = "";
                lblNombreEliminarRes.Text = "";
                lblTramiteEliminarRes.Text = "";
            }
        }
    }
}
