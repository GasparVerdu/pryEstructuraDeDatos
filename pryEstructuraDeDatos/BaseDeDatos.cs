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
    public partial class frmBaseDeDatos : Form
    {
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }

        clsBaseDeDatos objBD = new clsBaseDeDatos();

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT Titulo FROM Libro";
            objBD.Listar(grilla, varSql);
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT Titulo, Año FROM Libro";
            objBD.Listar(grilla, varSql);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT * FROM Libro WHERE precio >= 900";
            objBD.Listar(grilla, varSql);
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT * FROM Libro WHERE precio >= 800 AND precio <= 950 ";
            objBD.Listar(grilla, varSql);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            string varSql = " SELECT * FROM Libro WHERE idIdioma = 2 " +
                " union " +
                " SELECT * FROM Libro WHERE idIdioma = 3 ";
            objBD.Listar(grilla, varSql);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            string varSql = " SELECT * FROM Libro " +
                " WHERE idAutor = 5 AND exists " +
                " (SELECT * FROM Libro WHERE idIdioma = 3) ";
            objBD.Listar(grilla, varSql);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT * FROM libro " +
                " WHERE idIdioma = 2 and idLibro not in " +
                " (SELECT idLibro FROM libro WHERE idPais = 3 " +
                " order by 1 asc ";
            objBD.Listar(grilla, varSql);
        }
    }
}