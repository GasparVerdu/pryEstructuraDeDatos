using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace pryEstructuraDeDatos
{
    internal class clsBaseDeDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";

        public void Listar(DataGridView grilla) 
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";

                
                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Libro");

                grilla.DataSource = null;
                grilla.DataSource = DS.Tables["Libro"]; 


                conexion.Close();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
                conexion.Close();
            }
        }

        public void Listar(DataGridView grilla, string varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = varInstruccionSQL;


                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Resultado");

                grilla.DataSource = null;
                grilla.DataSource = DS.Tables["Resultado"];


                conexion.Close();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
                conexion.Close();
            }
        }
    }
}
