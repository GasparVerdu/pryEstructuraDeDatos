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
    public partial class frmEstructuraDatos : Form
    {
        public frmEstructuraDatos()
        {
            InitializeComponent();
        }

        private void datosDelProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatosProgramador frmDatosProgramador = new FrmDatosProgramador();
            frmDatosProgramador.ShowDialog();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmColas frmColas = new FrmColas();
            frmColas.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas frmPilas = new frmPilas();
            frmPilas.ShowDialog();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple frmListaSimple = new frmListaSimple();
            frmListaSimple.ShowDialog();
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDoble lista = new ListaDoble();
            lista.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario arbolBinario = new frmArbolBinario();
            arbolBinario.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void baseDeDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBaseDeDatos baseDeDatos = new frmBaseDeDatos();
            baseDeDatos.ShowDialog();
        }

        private void consultasEnBaseDeDatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaBaseDatos frmConsultaBaseDatos = new FrmConsultaBaseDatos();
            frmConsultaBaseDatos.ShowDialog();
        }

        private void repasoDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPorOperacion frmConsultaPorOperacion = new frmConsultaPorOperacion();
            frmConsultaPorOperacion.ShowDialog();
        }
    }
}
