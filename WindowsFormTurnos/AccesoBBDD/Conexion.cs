using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormTurnos.AccesoBBDD
{
    class Conexion
    {
        private MySqlConnection connection;

        private string server;
        private string database;
        private string uid;
        private string password;



        public Conexion()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "turnos";
            uid = "Facundo";
            password = "n0IHu9Ef0acPgpUx";
            string connectionString;

            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                MessageBox.Show("conexión exitosa","Mi Conexión");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(" Error al abrir la conexión [" + ex.Number + "]: " + ex.Message, "Mi Conexión");
                return false;
            }

        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cerrar la conexión [" + ex.Number + "]: " + ex.Message, "Mi Conexión");
                return false;
            }

        }
    }
}
