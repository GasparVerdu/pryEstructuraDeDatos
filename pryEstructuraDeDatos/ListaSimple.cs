﻿using System;
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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple listaSimple = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo objNodo = new ClsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            objNodo.Nombre = txtNombreNuevo.Text;
            objNodo.Tramite = txtTramiteNuevo.Text;

            listaSimple.Agregar(objNodo);
            listaSimple.Recorrer(grilla);
            listaSimple.Recorrer(lstListado);
            listaSimple.Recorrer(cboCodigo);
            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramiteNuevo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listaSimple.primero != null)
            {
                int codigo = Convert.ToInt32(cboCodigo.Text);
                listaSimple.Eliminar(codigo);
                listaSimple.Recorrer(lstListado);
                listaSimple.Recorrer(cboCodigo);
                listaSimple.Recorrer(grilla);
            }
            else
            {
                MessageBox.Show("la lista esta vacia ");
            }

            


        }
    }
}