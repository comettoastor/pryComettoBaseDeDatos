using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryComettoBaseDeDatos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BIBLIO.accdb; Persist Security Info = False");
            OleDbCommand comando = new OleDbCommand();
            OleDbDataReader dataReader;

            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "TITULO";

            dataReader = comando.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader[0]);
                }
            }
            conexion.Close();
        }
    }
}
