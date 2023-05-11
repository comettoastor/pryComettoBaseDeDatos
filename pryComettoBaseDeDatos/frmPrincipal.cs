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
using System.IO;

namespace pryComettoBaseDeDatos
{
    public partial class frmPrincipal : Form
    {
        OleDbConnection conexion;
        OleDbCommand comando;
        OleDbCommand comando_grupos;
        OleDbDataReader lector;
        OleDbDataReader lector_grupos;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();
            clsBaseDeDatos.Conectarse("VERDULEROS",btnMostrar);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            grdDatos.Rows.Clear();

            comando = new OleDbCommand();
            comando_grupos = new OleDbCommand();

            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Productos";

            comando_grupos.Connection = conexion;
            comando_grupos.CommandType = CommandType.TableDirect;
            comando_grupos.CommandText = "Grupos";

            string grupo = "";

            try
            {
                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        lector_grupos = comando_grupos.ExecuteReader();
                        while (lector_grupos.Read())
                        {
                            if (lector_grupos[0].ToString() == lector[2].ToString())
                            {
                                grupo = lector_grupos[1].ToString();
                            }
                        }
                        lector_grupos.Close();
                        if (decimal.Parse(lector[3].ToString()) >= nudDesde.Value && decimal.Parse(lector[3].ToString()) <= nudHasta.Value)
                        {
                            grdDatos.Rows.Add(lector[0], lector[1], grupo, lector[3]);
                        }
                    }
                }
                if (grdDatos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros","No encontrados",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
