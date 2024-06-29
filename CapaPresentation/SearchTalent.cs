using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentation
{
    public partial class SearchTalent : Form
    {
        public CNegocio client;
        public SearchTalent(CNegocio client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = client.GetTalent(inpEmail.Text);
            CEntidad talent = new CEntidad();
            this.Close();

            if (reader.Read())
            {
                talent.ID = reader.GetInt32(0);
                talent.Nombre = reader.GetString(1);
                talent.Apellido = reader.GetString(2);
                talent.Puesto = reader.GetString(3);
                talent.Telefono = reader.GetString(4);
                talent.Remuneracion = reader.GetDouble(5);
                talent.Curriculum = reader.GetString(6);

                UpdateTalentForm updateTalentForm = new UpdateTalentForm(talent);
                updateTalentForm.ShowDialog();

                client.db.Connection.Close();
            }
            else
            {
                MessageBox.Show("No se encontró el talento");
                return;
            }

        }
    }
}
