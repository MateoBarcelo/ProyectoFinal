using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentation.Utils;
using NReco.PdfRenderer;
using ImageFormat = System.Drawing.Imaging.ImageFormat;

namespace CapaPresentation
{
    public partial class AddTalentForm : Form
    {

        CNegocio client;
        public AddTalentForm()
        {
            InitializeComponent();
            client = new CNegocio(new CDatos());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CEntidad talent = new CEntidad();

            try
            {
                talent.Nombre = inpNombre.Text;
                talent.Apellido = inpApellido.Text;
                talent.Remuneracion = Convert.ToDouble(inpRemuneracion.Text);
                talent.Telefono = inpTelefono.Text;
                talent.Email = inpEmail.Text;
                talent.Puesto = inpPuesto.Text;
                talent.Curriculum = ImageUtils.imageToData(pbCV.Image, ImageFormat.Png);

                client.AddTalent(talent);
            } catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el talento, asegurate de colocar los datos en el formato correcto");
            }
        }

        private void lnkCV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdCV.ShowDialog();

            if (ofdCV.FileName.EndsWith(".pdf"))
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
