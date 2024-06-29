using CapaDatos;
using CapaEntidad;
using MySql.Data.MySqlClient;

namespace CapaNegocio
{
    public class CNegocio
    {
        public CDatos db;

        public CNegocio(CDatos connection)
        {
            db = connection;
        }

        public MySqlDataReader GetAllTalents()
        {
            db.Connection.Close(); // close before to avoid possible errors
            db.Connection.Open();

            string query = $"SELECT * FROM talentos";
            MySqlCommand command = new MySqlCommand(query, db.Connection);
            
            MySqlDataReader data = command.ExecuteReader();

            return data;
        }

        public MySqlDataReader GetTalent(string email)
        {
            db.Connection.Close();
            db.Connection.Open();

            string query = $"SELECT * FROM talentos WHERE Email='{email}'";
            MySqlCommand command = new MySqlCommand(query, db.Connection);

            MySqlDataReader data = command.ExecuteReader();

            return data;
        }

        public void AddTalent(CEntidad talent)
        {
            db.Connection.Close();
            db.Connection.Open();

            string query = $"INSERT INTO talentos(Nombre, Apellido, Telefono, Puesto, Remuneracion, Curriculum, Email) " +
          $"VALUES('{talent.Nombre}','{talent.Apellido}','{talent.Telefono}','{talent.Puesto}','{talent.Remuneracion}','{talent.Curriculum}','{talent.Email}')";
            MySqlCommand command = new MySqlCommand(query, db.Connection);
            command.ExecuteNonQuery();

            db.Connection.Close();
        }

        public void deleteTalent(string id)
        {
            db.Connection.Close();
            db.Connection.Open();

            string query = $"DELETE FROM talentos WHERE id = {id}";
            MySqlCommand command = new MySqlCommand(query, db.Connection);
            command.ExecuteNonQuery();

            db.Connection.Close();
        }

        public void updateTalent(CEntidad talent)
        {
            db.Connection.Close();
            db.Connection.Open();

            string query = $"UPDATE talentos SET Nombre = '{talent.Nombre}', Apellido = '{talent.Apellido}', Telefono = '{talent.Telefono}', Puesto = '{talent.Puesto}', Remuneracion = '{talent.Remuneracion}', Curriculum = '{talent.Curriculum}' WHERE id = {talent.ID}";
            MySqlCommand command = new MySqlCommand(query, db.Connection);
            command.ExecuteNonQuery();

            db.Connection.Close();
        }
    }
}
