using CapaNegocio;
using CapaDatos;
using MySql.Data.MySqlClient;
using System.Data;
using CapaPresentation.Utils;
using CapaEntidad;

namespace CapaPresentation
{
    public partial class Form1 : Form
    {

        public CNegocio client;
        public CDatos db;
        public Form1()
        {
            InitializeComponent();
            db = new CDatos();
            client = new CNegocio(db);
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTalentForm addTalentForm = new AddTalentForm();
            addTalentForm.ShowDialog();
        }

        public void updateTable()
        {
            DataTable table = new DataTable();

            MySqlDataReader dataReader = client.GetAllTalents();

            table.Load(dataReader);
            dtTalents.DataSource = table;

            dataReader.Close();
            db.Connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateTable();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow talent in dtTalents.SelectedRows)
            {
                //Cells in 0 is talent id
                client.deleteTalent(talent.Cells[0].Value.ToString());
            }

            updateTable();
        }

        private void dtTalents_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow talent = dtTalents.Rows[e.RowIndex];

            Image cvImage;
            try
            {
                cvImage = ImageUtils.dataToImage((talent.Cells[6].Value.ToString()));

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el curriculum");
                return;
            }

            CVViewer cVViewer = new CVViewer();
            cVViewer.CVProfile = cvImage;
            cVViewer.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtTalents.SelectedRows.Count == 0) return;

            if (dtTalents.SelectedRows.Count > 1)
            {
                MessageBox.Show("Seleccione solo un talento para actualizar", "Error!");
                return;
            }

            DataGridViewRow talent = dtTalents.SelectedRows[0];
            CEntidad oneTalent = new CEntidad()
            {
                ID = Convert.ToInt16(talent.Cells[0].Value.ToString()),
                Nombre = talent.Cells[1].Value.ToString(),
                Apellido = talent.Cells[2].Value.ToString(),
                Telefono = talent.Cells[3].Value.ToString(),
                Puesto = talent.Cells[4].Value.ToString(),
                Remuneracion = Convert.ToInt32(talent.Cells[5].Value.ToString()),
                Curriculum = talent.Cells[6].Value.ToString()
            };

            UpdateTalentForm updateTalentForm = new UpdateTalentForm(oneTalent);
            updateTalentForm.ShowDialog();
        }

        private void tsActualizar_Click(object sender, EventArgs e)
        {
            SearchTalent searchForm = new SearchTalent(client);
            searchForm.ShowDialog();
        }
    }
}
