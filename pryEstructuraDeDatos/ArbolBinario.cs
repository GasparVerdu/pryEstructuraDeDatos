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
            if (txtCodigoNuevo.Text != "" & txtNombreNuevo.Text != "" & txtTramiteNuevo.Text != "")
            {
                nodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
                nodo.Nombre = txtNombreNuevo.Text;
                nodo.Tramite = txtTramiteNuevo.Text;
                //streamwriter

                arbolBinario.agregar(nodo);

                arbolBinario.RecorrerASC(lstListado);
                arbolBinario.RecorrerASC(cboCodigo);
                arbolBinario.RecorrerASC(grilla);
                arbolBinario.RecorrerASC(cboCodBuscar);
                arbolBinario.RecorrerPRE(TView);

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
            if (arbolBinario.raiz != null)
            {
                Int32 Borrar = Convert.ToInt32(cboCodigo.Text);
                arbolBinario.Eliminar(Borrar);
                arbolBinario.RecorrerASC(grilla);
                arbolBinario.RecorrerASC(lstListado);
                arbolBinario.RecorrerASC(cboCodigo);
                arbolBinario.RecorrerASC(cboCodBuscar);
                arbolBinario.RecorrerPRE(TView);
            }
            else
            {
                MessageBox.Show("Selecciona un item para eliminar");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboCodBuscar.Text != "")
            {
                if (arbolBinario != null)
                {
                    Int32 varCodigo = Convert.ToInt32(cboCodBuscar.Text);
                    ClsNodo x = arbolBinario.cmdBuscar(varCodigo);
                    txtNombreBus.Text = x.Nombre;
                    txtTramiteBus.Text = x.Tramite;
                }
                else
                {
                    MessageBox.Show("Código no encontrado");
                }
                cboCodBuscar.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, seleccionar que codigo desea buscar");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            if (arbolBinario.raiz != null)
            {
                arbolBinario.Equilibrar();
                arbolBinario.RecorrerPRE(TView);
            }
            else
            {
                MessageBox.Show("Cargue datos en el arbol");
            }
        }

        private void TView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void cboCodBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
