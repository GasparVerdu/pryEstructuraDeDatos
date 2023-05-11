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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        ClsArbolBinario arbolBinario = new ClsArbolBinario();

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo nodo = new ClsNodo();
            nodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            nodo.Nombre = txtNombreNuevo.Text;
            nodo.Tramite = txtTramiteNuevo.Text;
            //streamwriter

            arbolBinario.agregar(nodo);

            arbolBinario.RecorrerASC(lstListado);
            arbolBinario.RecorrerASC(cboCodigo);
            arbolBinario.RecorrerASC(grilla);

            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramiteNuevo.Text = "";

            txtCodigoNuevo.Focus();


        }

        private void rdbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAscendente.Checked == true)
            {
                arbolBinario.RecorrerASC(lstListado);
                arbolBinario.RecorrerASC(cboCodigo);
                arbolBinario.RecorrerASC(grilla);
            }

        }

        private void rdbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDescendente.Checked== true)
            {
                arbolBinario.RecorrerDSC(lstListado);
                arbolBinario.RecorrerDSC(cboCodigo);
                arbolBinario.RecorrerDSC(grilla);
            }
        }

        private void rdbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPreOrden.Checked == true)
            {
                arbolBinario.RecorrerPRE(lstListado);
                arbolBinario.RecorrerPRE(cboCodigo);
                arbolBinario.RecorrerPRE(grilla);
            }
        }

        private void rdbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPostOrden.Checked == true)
            {
                arbolBinario.RecorrerPOST(lstListado);
                arbolBinario.RecorrerPOST(cboCodigo);
                arbolBinario.RecorrerPOST(grilla);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }
    }
}
