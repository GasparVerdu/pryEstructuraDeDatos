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
    public partial class frmPilas : Form
    {
        public frmPilas()
        {
            InitializeComponent();
        }
        ClsPila objPila = new ClsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo objNodo = new ClsNodo();

            if (txtCodigoNuevo.Text != "" & txtNombreNuevo.Text != "" & txtTramiteNuevo.Text != "")
            {
                
                objNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
                objNodo.Nombre = txtNombreNuevo.Text;
                objNodo.Tramite = txtTramiteNuevo.Text;

                objPila.Agregar(objNodo);
                objPila.Recorrer(grilla);
                objPila.Recorrer(lstListado);
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
            if (objPila.primero != null)
            {
                lblCodigoEliminarRes.Text = objPila.primero.Codigo.ToString();
                lblNombreEliminarRes.Text = objPila.primero.Nombre;
                lblTramiteEliminarRes.Text = objPila.primero.Tramite;

                objPila.Eliminar();
                objPila.Recorrer(grilla);
                objPila.Recorrer(lstListado);
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
