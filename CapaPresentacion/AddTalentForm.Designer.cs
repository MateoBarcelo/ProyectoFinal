namespace CapaPresentacion
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.inpNombre = new System.Windows.Forms.TextBox();
            this.inpApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inpPuesto = new System.Windows.Forms.TextBox();
            this.lblP = new System.Windows.Forms.Label();
            this.inpRemuneracion = new System.Windows.Forms.TextBox();
            this.lblRem = new System.Windows.Forms.Label();
            this.inpTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.picCV = new System.Windows.Forms.PictureBox();
            this.linkCV = new System.Windows.Forms.LinkLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(75, 63);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(78, 24);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Nombre";
            // 
            // inpNombre
            // 
            this.inpNombre.Location = new System.Drawing.Point(79, 106);
            this.inpNombre.Name = "inpNombre";
            this.inpNombre.Size = new System.Drawing.Size(214, 26);
            this.inpNombre.TabIndex = 1;
            // 
            // inpApellido
            // 
            this.inpApellido.Location = new System.Drawing.Point(382, 106);
            this.inpApellido.Name = "inpApellido";
            this.inpApellido.Size = new System.Drawing.Size(214, 26);
            this.inpApellido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido";
            // 
            // inpPuesto
            // 
            this.inpPuesto.Location = new System.Drawing.Point(79, 213);
            this.inpPuesto.Name = "inpPuesto";
            this.inpPuesto.Size = new System.Drawing.Size(214, 26);
            this.inpPuesto.TabIndex = 5;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(75, 170);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(67, 24);
            this.lblP.TabIndex = 4;
            this.lblP.Text = "Puesto";
            // 
            // inpRemuneracion
            // 
            this.inpRemuneracion.Location = new System.Drawing.Point(382, 213);
            this.inpRemuneracion.Name = "inpRemuneracion";
            this.inpRemuneracion.Size = new System.Drawing.Size(214, 26);
            this.inpRemuneracion.TabIndex = 7;
            // 
            // lblRem
            // 
            this.lblRem.AutoSize = true;
            this.lblRem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRem.Location = new System.Drawing.Point(378, 170);
            this.lblRem.Name = "lblRem";
            this.lblRem.Size = new System.Drawing.Size(131, 24);
            this.lblRem.TabIndex = 6;
            this.lblRem.Text = "Remuneracion";
            // 
            // inpTelefono
            // 
            this.inpTelefono.Location = new System.Drawing.Point(79, 329);
            this.inpTelefono.Name = "inpTelefono";
            this.inpTelefono.Size = new System.Drawing.Size(214, 26);
            this.inpTelefono.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(75, 286);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(82, 24);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono";
            // 
            // picCV
            // 
            this.picCV.Location = new System.Drawing.Point(412, 338);
            this.picCV.Name = "picCV";
            this.picCV.Size = new System.Drawing.Size(160, 194);
            this.picCV.TabIndex = 10;
            this.picCV.TabStop = false;
            // 
            // linkCV
            // 
            this.linkCV.AutoSize = true;
            this.linkCV.Location = new System.Drawing.Point(438, 290);
            this.linkCV.Name = "linkCV";
            this.linkCV.Size = new System.Drawing.Size(101, 20);
            this.linkCV.TabIndex = 11;
            this.linkCV.TabStop = true;
            this.linkCV.Text = "Examinar CV";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(121, 480);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 52);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddTalentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 565);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.linkCV);
            this.Controls.Add(this.picCV);
            this.Controls.Add(this.inpTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.inpRemuneracion);
            this.Controls.Add(this.lblRem);
            this.Controls.Add(this.inpPuesto);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.inpApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inpNombre);
            this.Controls.Add(this.lbl1);
            this.Name = "AddTalentForm";
            this.Text = "AddTalentForm";
            ((System.ComponentModel.ISupportInitialize)(this.picCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox inpNombre;
        private System.Windows.Forms.TextBox inpApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inpPuesto;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox inpRemuneracion;
        private System.Windows.Forms.Label lblRem;
        private System.Windows.Forms.TextBox inpTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.PictureBox picCV;
        private System.Windows.Forms.LinkLabel linkCV;
        private System.Windows.Forms.Button btnAdd;
    }
}