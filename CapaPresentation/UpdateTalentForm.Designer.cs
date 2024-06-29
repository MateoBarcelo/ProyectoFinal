namespace CapaPresentation
{
    partial class UpdateTalentForm
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
            btnAgregar = new Button();
            pbCV = new PictureBox();
            inpTelefono = new TextBox();
            label5 = new Label();
            inpRemuneracion = new TextBox();
            label4 = new Label();
            inpPuesto = new TextBox();
            label3 = new Label();
            inpApellido = new TextBox();
            label2 = new Label();
            inpNombre = new TextBox();
            label1 = new Label();
            lnkCV = new LinkLabel();
            ofdCV = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbCV).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Turquoise;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(622, 337);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(126, 48);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Actualizar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pbCV
            // 
            pbCV.Location = new Point(603, 103);
            pbCV.Name = "pbCV";
            pbCV.Size = new Size(150, 180);
            pbCV.SizeMode = PictureBoxSizeMode.Zoom;
            pbCV.TabIndex = 24;
            pbCV.TabStop = false;
            // 
            // inpTelefono
            // 
            inpTelefono.Location = new Point(47, 314);
            inpTelefono.Name = "inpTelefono";
            inpTelefono.Size = new Size(213, 31);
            inpTelefono.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 277);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 21;
            label5.Text = "Telefono";
            // 
            // inpRemuneracion
            // 
            inpRemuneracion.Location = new Point(319, 206);
            inpRemuneracion.Name = "inpRemuneracion";
            inpRemuneracion.Size = new Size(213, 31);
            inpRemuneracion.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 169);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 19;
            label4.Text = "Remuneracion";
            // 
            // inpPuesto
            // 
            inpPuesto.Location = new Point(47, 206);
            inpPuesto.Name = "inpPuesto";
            inpPuesto.Size = new Size(213, 31);
            inpPuesto.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 169);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 17;
            label3.Text = "Puesto";
            // 
            // inpApellido
            // 
            inpApellido.Location = new Point(319, 103);
            inpApellido.Name = "inpApellido";
            inpApellido.Size = new Size(213, 31);
            inpApellido.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 66);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 15;
            label2.Text = "Apellido";
            // 
            // inpNombre
            // 
            inpNombre.Location = new Point(47, 103);
            inpNombre.Name = "inpNombre";
            inpNombre.Size = new Size(213, 31);
            inpNombre.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 66);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 13;
            label1.Text = "Nombre";
            // 
            // lnkCV
            // 
            lnkCV.AutoSize = true;
            lnkCV.Location = new Point(622, 66);
            lnkCV.Name = "lnkCV";
            lnkCV.Size = new Size(110, 25);
            lnkCV.TabIndex = 23;
            lnkCV.TabStop = true;
            lnkCV.Text = "Examinar CV";
            lnkCV.LinkClicked += lnkCV_LinkClicked;
            // 
            // ofdCV
            // 
            ofdCV.FileName = "openFileDialog1";
            // 
            // UpdateTalentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(pbCV);
            Controls.Add(lnkCV);
            Controls.Add(inpTelefono);
            Controls.Add(label5);
            Controls.Add(inpRemuneracion);
            Controls.Add(label4);
            Controls.Add(inpPuesto);
            Controls.Add(label3);
            Controls.Add(inpApellido);
            Controls.Add(label2);
            Controls.Add(inpNombre);
            Controls.Add(label1);
            Name = "UpdateTalentForm";
            Text = "Actualizar talento";
            Load += UpdateTalentForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)pbCV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private PictureBox pbCV;
        private TextBox inpTelefono;
        private Label label5;
        private TextBox inpRemuneracion;
        private Label label4;
        private TextBox inpPuesto;
        private Label label3;
        private TextBox inpApellido;
        private Label label2;
        private TextBox inpNombre;
        private Label label1;
        private LinkLabel lnkCV;
        private OpenFileDialog ofdCV;
    }
}