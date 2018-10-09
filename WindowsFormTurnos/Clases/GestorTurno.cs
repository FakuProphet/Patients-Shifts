using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;



using WindowsFormTurnos.AccesoBBDD;



namespace WindowsFormTurnos.Clases
{
    class GestorTurno
    {


        Conexion miConexion = new Conexion();
        MySqlDataReader dr;


        public MySqlDataReader pDr
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
            String query = "INSERT INTO turnoslab (nombrePaciente,eritro,cito,retis,dni,horaID,fecha) " +
                           "VALUES (@paciente,@eritro,@cito,@reti,@dni,@horaID,@fecha)";
            using (MySqlCommand command = new MySqlCommand(query,miConexion.OpenConnection()))
            {
                command.Parameters.AddWithValue("@paciente", t.nombre );
                command.Parameters.AddWithValue("@cito", t.cito);
                command.Parameters.AddWithValue("@eritro", t.eritro);
                command.Parameters.AddWithValue("@reti", t.reti);
                command.Parameters.AddWithValue("@dni", t.documento);
                command.Parameters.AddWithValue("@horaID", t.idHora);
                command.Parameters.AddWithValue("@fecha", t.fecha);
                int result = command.ExecuteNonQuery();
            }

        }



        public bool GetDisponibilidadHora(int id, string fecha)
        {

           MySqlCommand cmd = new MySqlCommand("select horaID from turnoslab where horaID=" + id + " and fecha like '%" + fecha + "%'", miConexion.OpenConnection());
           MySqlDataReader dr = cmd.ExecuteReader();
            bool bandera = true;

            if (dr.Read())

            {
                if (!pDr.IsDBNull(0))
                {
                    bandera = false;
                }
                if (pDr.IsDBNull(0))
                {
                    bandera = true;
                }
            }
           

            dr.Close();
            miConexion.CloseConnection();
            return bandera;
        }

    }
}
