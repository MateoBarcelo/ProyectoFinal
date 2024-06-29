using MySql.Data.MySqlClient;
using CapaEntidad;
namespace CapaDatos
{
    public class CDatos
    {
        public MySqlConnection Connection { get; set; }

        public CDatos() { 

            try
            {
                Connection = new MySqlConnection(DB.ConnectionString);
            } catch(Exception e) {
                Console.WriteLine(e.ToString());
            }

        } 

        public void AddTalent(CEntidad talent, MySqlConnection conn)
        {
            conn.Open();
            string query = $"INSERT INTO talentos(Nombre, Apellido, Telefono, Puesto, Remuneracion, Curriculum) " +
          $"VALUES('{talent.Nombre}','{talent.Apellido}','{talent.Telefono}','{talent.Puesto}','{talent.Remuneracion}','{talent.Curriculum}')";
            
            MySqlCommand command = new MySqlCommand(query, Connection);
            command.ExecuteNonQuery();

            conn.Close();
        }
    }
}
