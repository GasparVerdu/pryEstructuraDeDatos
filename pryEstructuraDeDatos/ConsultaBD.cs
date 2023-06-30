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
    public partial class FrmConsultaBaseDatos : Form
    {
        public FrmConsultaBaseDatos()
        {
            InitializeComponent();
        }

        clsBaseDeDatos objBaseDatos = new clsBaseDeDatos();

        private void btnListar_Click(object sender, EventArgs e)
        {
            string varSql = txtConsultaSql.Text;

            objBaseDatos.Listar(grilla, varSql);
        }

        private void FrmConsultaBaseDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
