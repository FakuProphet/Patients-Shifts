using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormTurnos.AccesoBBDD;

namespace WindowsFormTurnos.Clases
{
    class GestorTurno
    {

        SqlCommand cmd;
        SqlDataReader dr;
        const int tam = 1000;
        Conexion miConexion= new Conexion();


      

        public SqlDataReader pDr
        { set { dr = value; } get { return dr; } }


        public void generarTurno(int codigoPac, int hora,  int ext, int cito, int eritro, int reti)
        {

            String query = "INSERT INTO TURNOS (paciente,hora,extraccion,citologico,eritrosedimentacion,reticulocitos) " +
                           "VALUES (@paciente,@hora,@ext,@cito,@eritro,@reti)";
            using (MySqlCommand command = new MySqlCommand(query,miConexion.OpenConnection()))
            {
                command.Parameters.AddWithValue("@ext", ext);
                command.Parameters.AddWithValue("@cito", cito);
                command.Parameters.AddWithValue("@eritro", eritro);
                command.Parameters.AddWithValue("@reti", reti);
                command.Parameters.AddWithValue("@paciente", codigoPac);
                command.Parameters.AddWithValue("@hora", hora);

                int result = command.ExecuteNonQuery();
            }

        }
    }
}
