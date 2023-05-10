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
        OleDbConnection conexion;
        OleDbCommand comando;
        OleDbDataReader lector;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VERDULEROS.mdb;");

            try
            {
                conexion.Open();
                MessageBox.Show("Conexión establecida con la base de datos","Conexión Establecida",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnMostrar.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            grdDatos.Rows.Clear();

            comando = new OleDbCommand();

            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Productos";

            try
            {
                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        if (decimal.Parse(lector[3].ToString()) >= nudDesde.Value && decimal.Parse(lector[3].ToString()) <= nudHasta.Value)
                        {
                            grdDatos.Rows.Add(lector[0], lector[1], lector[2], lector[3]);
                        }
                    }
                }
                if (grdDatos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros","No encontrados",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    //MessageBox.Show("Registros encontrados","Encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
