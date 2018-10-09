using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormTurnos.AccesoBBDD;

namespace WindowsFormTurnos.Clases
{
    class GestorTurno
    {

        
        SqlDataReader dr;
        const int tam = 1000;
        Conexion miConexion= new Conexion();


      

        public SqlDataReader pDr
        { set { dr = value; } get { return dr; } }


        public DataTable realizarConsulta(string tabla)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("select * from " + tabla + "", miConexion.OpenConnection());
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            miConexion.CloseConnection();
            return dt;
        }

        public void generarTurno(string paciente,int ext, int cito, int eritro, int reti,int dni)
        {
            String cadena = miConexion.GetCadenaConexion;
            String query = "INSERT INTO TURNOS (nombrePaciente,eritro,cito,retis,dni) " +
                           "VALUES (@paciente,@eritro,@cito,@reti,@dni)";
            using (MySqlCommand command = new MySqlCommand(query,miConexion.OpenConnection()))
            {
                command.Parameters.AddWithValue("@paciente", paciente);
                command.Parameters.AddWithValue("@cito", cito);
                command.Parameters.AddWithValue("@eritro", eritro);
                command.Parameters.AddWithValue("@reti", reti);
                command.Parameters.AddWithValue("@dni", dni);
                int result = command.ExecuteNonQuery();
            }

        }
    }
}
