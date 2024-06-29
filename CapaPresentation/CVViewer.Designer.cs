namespace CapaPresentation
{
    partial class CVViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbCv = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCv).BeginInit();
            SuspendLayout();
            // 
            // pbCv
            // 
            pbCv.Location = new Point(12, 12);
            pbCv.Name = "pbCv";
            pbCv.Size = new Size(720, 977);
            pbCv.SizeMode = PictureBoxSizeMode.Zoom;
            pbCv.TabIndex = 0;
            pbCv.TabStop = false;
            // 
            // CVViewer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 821);
            Controls.Add(pbCv);
            Name = "CVViewer";
            Text = "Visualizador";
            Load += CVViewer_Load;
            ((System.ComponentModel.ISupportInitialize)pbCv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbCv;
    }
}