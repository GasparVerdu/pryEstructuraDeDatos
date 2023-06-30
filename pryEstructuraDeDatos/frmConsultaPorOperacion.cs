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
    public partial class frmConsultaPorOperacion : Form
    {
        public frmConsultaPorOperacion()
        {
            InitializeComponent();
        }
        
        clsBaseDeDatos objBD = new clsBaseDeDatos();

        private void cmdListar_Click(object sender, EventArgs e)
        {
            
            String varSql = "SELECT * FROM LIBRO";
            switch (cmbConsulta.SelectedIndex)
            {
                
                case 0:
                    lblEnunciado.Text = cmbConsulta.Text + ":       "
                        + "Idiomas que no tienen libros ";
                    varSql = "Select * from idioma where " +
                        "Ididioma not in " + "(Select IdIdioma from Libro) ";
                    objBD.Listar(dgv, varSql);
                    break;
                
                case 1:
                    lblEnunciado.Text = cmbConsulta.Text +
                        "Idiomas que si tienen libros ";
                    varSql = "Select * From Idioma where " +
                        " IdIdioma in " +
                        " (Select IdIdioma from Libro) ";
                    objBD.Listar(dgv, varSql);
                    break;

                case 2:
                    lblEnunciado.Text = cmbConsulta.Text + ": " +
                        "Libros y Autores";
                    varSql = "Select  Titulo, Nombre " +
                        "from Libro inner join Autor " +
                        "on Libro.IdAutor = Autor.IdAutor ";

                    objBD.Listar(dgv, varSql);
                    break;

                case 3:
                    lblEnunciado.Text = cmbConsulta.Text + ": " +
                        "Todos los autores de los libros";
                    varSql = "Select Nombre From Autor";
                    objBD.Listar(dgv, varSql);
                    break;

                case 4: 
                    lblEnunciado.Text = cmbConsulta.Text + ":" +
                        "Muestra Pais, Titulo y Cantidad";
                    varSql = "Select IdPais, Titulo, Cantidad from Libro";
                    objBD.Listar(dgv, varSql);
                    break;

                case 5:
                    lblEnunciado.Text = cmbConsulta.Text + ":" +
                        "Muestra todos los libros Alemanes con su precio ";
                    varSql = "Select * from Libro " +
                        "where IdPais =  5 AND Precio ";
                    objBD.Listar(dgv, varSql);
                    break;

                case 6:
                    lblEnunciado.Text = cmbConsulta.Text + ":" +
                     "Muestra todos los libros que su autor sea Carlos o Virginia ";
                    varSql = "Select * from Libro " +
                        "where IdAutor = 2 OR IdAutor = 3 ";
                    objBD.Listar(dgv, varSql);

                    break;

                case 7:
                    lblEnunciado.Text = cmbConsulta.Text + ":" +
                     "Muestra los libros de Alemania con cantidad mayor que 2 ";
                    varSql = "Select * From " +
                        "(Select  Titulo, Cantidad, IdPais, IdIdioma From Libro where Cantidad > 2) as X " +
                        "Where IdIdioma = 3 ";
                    objBD.Listar(dgv, varSql);
                    break;

                case 8:
                    lblEnunciado.Text = cmbConsulta.Text + ":" +
                    "Muestra los libros con cantidad mayor que 5 ";
                    varSql = "Select Titulo from Libro " +
                        "where Cantidad > 5 ";
                    objBD.Listar(dgv, varSql);
                    break;

                case 9: 
                    lblEnunciado.Text = cmbConsulta.Text + ":" +
                        "Muestra los libros con Idoma  Hebreo y Noruego";
                    varSql = "Select * From Libro " +
                        " where IdIdioma = 18 " +
                        "union " +
                        "Select * From Libro where IdIdioma = 7";
                    objBD.Listar(dgv, varSql);
                    break;
            }
        }
    }
}
