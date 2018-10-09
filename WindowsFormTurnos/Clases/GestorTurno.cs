using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;



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

        public void generarTurno(Turno t)
        {
            String cadena = miConexion.GetCadenaConexion;
            String query = "INSERT INTO TURNOS (nombrePaciente,eritro,cito,retis,dni,horaID) " +
                           "VALUES (@paciente,@eritro,@cito,@reti,@dni,@horaID)";
            using (MySqlCommand command = new MySqlCommand(query,miConexion.OpenConnection()))
            {
                command.Parameters.AddWithValue("@paciente", t.nombre );
                command.Parameters.AddWithValue("@cito", t.cito);
                command.Parameters.AddWithValue("@eritro", t.eritro);
                command.Parameters.AddWithValue("@reti", t.reti);
                command.Parameters.AddWithValue("@dni", t.documento);
                command.Parameters.AddWithValue("@horaID", t.idHora);
                int result = command.ExecuteNonQuery();
            }

        }
    }
}
