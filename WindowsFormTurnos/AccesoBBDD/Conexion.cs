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
        private string cadena;

      

        public string GetCadenaConexion
        {
            get { return cadena; }      
        }


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
            cadena = connectionString;

            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection OpenConnection()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadena);
                connection.Open();
                MessageBox.Show("Conexión exitosa", "Mi conexión");
                return conexion;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error en la conexion: " + ex.ToString());
            }

        }

        //Close connection
        public MySqlConnection CloseConnection()
        {
            MySqlConnection desconectar = new MySqlConnection(cadena);
            desconectar.Close();
            desconectar.Dispose();
            return desconectar;
        }
    }
}
