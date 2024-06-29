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
    public partial class CVViewer : Form
    {
        public Image CVProfile { get; set; }
        public CVViewer()
        {
            InitializeComponent();
        }

        private void CVViewer_Load(object sender, EventArgs e)
        {
            pbCv.Image = CVProfile;
            this.Width = pbCv.Width + 45;
            this.Height = pbCv.Height;
        }


    }
}
