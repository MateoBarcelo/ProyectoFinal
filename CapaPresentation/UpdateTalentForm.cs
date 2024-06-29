using CapaEntidad;
using CapaNegocio;
using CapaDatos;
using CapaPresentation.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReco.PdfRenderer;
using ImageFormat = System.Drawing.Imaging.ImageFormat;

namespace CapaPresentation
{
    public partial class UpdateTalentForm : Form
    {
        CEntidad talent;
        CNegocio client;
        public UpdateTalentForm(CEntidad talent)
        {
            InitializeComponent();
            this.talent = talent;
            client = new CNegocio(new CDatos());
        }
        private void UpdateTalentForm_Load_1(object sender, EventArgs e)
        {
            inpNombre.Text = talent.Nombre;
            inpApellido.Text = talent.Apellido;
            inpPuesto.Text = talent.Puesto;
            inpTelefono.Text = talent.Telefono;
            inpRemuneracion.Text = talent.Remuneracion.ToString();
            pbCV.Image = ImageUtils.dataToImage(talent.Curriculum);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                talent.Nombre = inpNombre.Text;
                talent.Apellido = inpApellido.Text;
                talent.Puesto = inpPuesto.Text;
                talent.Telefono = inpTelefono.Text;
                talent.Remuneracion = Convert.ToInt32(inpRemuneracion.Text);
                talent.Curriculum = ImageUtils.imageToData(pbCV.Image, ImageFormat.Png);

                client.updateTalent(talent);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el talento, asegurate de colocar los datos en el formato correcto");
            }
        }

        private void lnkCV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdCV.ShowDialog();

            if(ofdCV.FileName.EndsWith(".pdf"))
            {
                PdfToImageConverter pdfToImg = new NReco.PdfRenderer.PdfToImageConverter();
                Image cvImage = pdfToImg.GenerateImage(ofdCV.FileName, 1);

                pbCV.Image = cvImage;
                return;
            }
            Image img = Image.FromFile(ofdCV.FileName);

            pbCV.Image = img;
        }
    }
}
