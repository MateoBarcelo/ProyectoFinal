namespace CapaPresentation
{
    partial class AddTalentForm
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
            label1 = new Label();
            inpNombre = new TextBox();
            inpApellido = new TextBox();
            label2 = new Label();
            inpPuesto = new TextBox();
            label3 = new Label();
            inpRemuneracion = new TextBox();
            label4 = new Label();
            inpTelefono = new TextBox();
            label5 = new Label();
            lnkCV = new LinkLabel();
            pbCV = new PictureBox();
            ofdCV = new OpenFileDialog();
            btnAgregar = new Button();
            inpEmail = new TextBox();
            Email = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 65);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // inpNombre
            // 
            inpNombre.Location = new Point(87, 102);
            inpNombre.Name = "inpNombre";
            inpNombre.Size = new Size(213, 31);
            inpNombre.TabIndex = 1;
            // 
            // inpApellido
            // 
            inpApellido.Location = new Point(359, 102);
            inpApellido.Name = "inpApellido";
            inpApellido.Size = new Size(213, 31);
            inpApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 65);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // inpPuesto
            // 
            inpPuesto.Location = new Point(87, 205);
            inpPuesto.Name = "inpPuesto";
            inpPuesto.Size = new Size(213, 31);
            inpPuesto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 168);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 4;
            label3.Text = "Puesto";
            // 
            // inpRemuneracion
            // 
            inpRemuneracion.Location = new Point(359, 205);
            inpRemuneracion.Name = "inpRemuneracion";
            inpRemuneracion.Size = new Size(213, 31);
            inpRemuneracion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 168);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 6;
            label4.Text = "Remuneracion";
            // 
            // inpTelefono
            // 
            inpTelefono.Location = new Point(87, 313);
            inpTelefono.Name = "inpTelefono";
            inpTelefono.Size = new Size(213, 31);
            inpTelefono.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 276);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 8;
            label5.Text = "Telefono";
            // 
            // lnkCV
            // 
            lnkCV.AutoSize = true;
            lnkCV.Location = new Point(694, 65);
            lnkCV.Name = "lnkCV";
            lnkCV.Size = new Size(110, 25);
            lnkCV.TabIndex = 10;
            lnkCV.TabStop = true;
            lnkCV.Text = "Examinar CV";
            lnkCV.LinkClicked += lnkCV_LinkClicked;
            // 
            // pbCV
            // 
            pbCV.Location = new Point(675, 102);
            pbCV.Name = "pbCV";
            pbCV.Size = new Size(150, 180);
            pbCV.SizeMode = PictureBoxSizeMode.Zoom;
            pbCV.TabIndex = 11;
            pbCV.TabStop = false;
            // 
            // ofdCV
            // 
            ofdCV.FileName = "openFileDialog1";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.PaleGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(687, 313);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(126, 48);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // inpEmail
            // 
            inpEmail.Location = new Point(359, 313);
            inpEmail.Name = "inpEmail";
            inpEmail.Size = new Size(213, 31);
            inpEmail.TabIndex = 14;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(359, 276);
            Email.Name = "Email";
            Email.Size = new Size(54, 25);
            Email.TabIndex = 13;
            Email.Text = "Email";
            // 
            // AddTalentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 438);
            Controls.Add(inpEmail);
            Controls.Add(Email);
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
            Name = "AddTalentForm";
            Text = "AddTalentForm";
            ((System.ComponentModel.ISupportInitialize)pbCV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inpNombre;
        private TextBox inpApellido;
        private Label label2;
        private TextBox inpPuesto;
        private Label label3;
        private TextBox inpRemuneracion;
        private Label label4;
        private TextBox inpTelefono;
        private Label label5;
        private LinkLabel lnkCV;
        private PictureBox pbCV;
        private OpenFileDialog ofdCV;
        private Button btnAgregar;
        private TextBox inpEmail;
        private Label Email;
    }
}