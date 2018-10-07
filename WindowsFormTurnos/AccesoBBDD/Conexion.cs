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
            database = "miBBDD";
            uid = "faku";
            password = "passw0rd";
            string connectionString;

            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexión ok");
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(" Error al abrir la conexión [" + ex.Number + "]: " + ex.Message);
                return false;
            }

        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cerrar la conexión [" + ex.Number + "]: " + ex.Message);
                return false;
            }

        }
    }
}
