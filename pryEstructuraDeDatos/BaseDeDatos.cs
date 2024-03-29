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
            string varSql = "Select Titulo, Nombre " +
                "From Libro inner join Pais " +
                "on Libro.IdPais = Pais.IdPais ";
            objBD.Listar(grilla, varSql);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT * FROM Libro WHERE precio >= 900";
            objBD.Listar(grilla, varSql);
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            //
            string varSql = "SELECT * FROM Libro WHERE precio >= 800 AND precio <= 950 ";
            objBD.Listar(grilla, varSql);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            string varSql = " SELECT * FROM Libro WHERE idIdioma = 1 " +
                " union " +
                " SELECT * FROM Libro WHERE idIdioma = 2 ";
            objBD.Listar(grilla, varSql);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            string varSql = " SELECT * FROM Libro " +
                " WHERE IdIdioma = 5 AND " +
                " idlibro in " +
                " (select idlibro from libro where idpais =2) " +
                " order by 1 asc " ;                
            objBD.Listar(grilla, varSql);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT * FROM libro " +
                " WHERE idIdioma = 2 and " +
                " idLibro not in " +
                " (SELECT IdLibro FROM libro WHERE idPais = 3 )" +
                " order by 1 asc ";
            objBD.Listar(grilla, varSql);
        }

        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            //ojo
            string varSql = " SELECT * " +
                " FROM (select * from libro where IdIdioma > 2) as X " +
                " WHERE IdPais = 1 " +
                " ORDER BY TITULO ";
            objBD.Listar(grilla, varSql);
        }

        private void frmBaseDeDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
