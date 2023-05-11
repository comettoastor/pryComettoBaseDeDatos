using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryComettoBaseDeDatos
{
    internal class clsBaseDeDatos
    {
        OleDbConnection conexion;
        OleDbCommand comando;
        OleDbDataAdapter lector;

        public void Conectarse(string archivo,Button boton_mostrar)
        {
            conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + archivo + ".mdb;");

            try
            {
                //La conexion tiene que ser para 12.0 y 4.0 por lo que debo usar GetFileExtension para saber si el archivo de base de datos es .mdb o .accdb
                //Tambien añadir la posibilidad de buscar por grupo
                conexion.Open();
                MessageBox.Show("Conexión establecida con la base de datos", "Conexión Establecida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                boton_mostrar.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
