namespace CapaPresentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            talentosToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            tsActualizar = new ToolStripMenuItem();
            dtTalents = new DataGridView();
            label1 = new Label();
            btnReload = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtTalents).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { talentosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1317, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // talentosToolStripMenuItem
            // 
            talentosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, tsActualizar });
            talentosToolStripMenuItem.Name = "talentosToolStripMenuItem";
            talentosToolStripMenuItem.Size = new Size(92, 29);
            talentosToolStripMenuItem.Text = "Talentos";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(270, 34);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // tsActualizar
            // 
            tsActualizar.Name = "tsActualizar";
            tsActualizar.Size = new Size(270, 34);
            tsActualizar.Text = "Actualizar";
            tsActualizar.Click += tsActualizar_Click;
            // 
            // dtTalents
            // 
            dtTalents.AllowUserToAddRows = false;
            dtTalents.AllowUserToDeleteRows = false;
            dtTalents.BackgroundColor = Color.SteelBlue;
            dtTalents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtTalents.GridColor = SystemColors.WindowText;
            dtTalents.Location = new Point(130, 136);
            dtTalents.Name = "dtTalents";
            dtTalents.ReadOnly = true;
            dtTalents.RowHeadersWidth = 62;
            dtTalents.Size = new Size(1061, 585);
            dtTalents.TabIndex = 1;
            dtTalents.CellContentDoubleClick += dtTalents_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 77);
            label1.Name = "label1";
            label1.Size = new Size(227, 38);
            label1.TabIndex = 2;
            label1.Text = "Talentos subidos";
            // 
            // btnReload
            // 
            btnReload.FlatAppearance.BorderSize = 0;
            btnReload.FlatStyle = FlatStyle.Flat;
            btnReload.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            btnReload.IconColor = Color.Black;
            btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReload.IconSize = 38;
            btnReload.Location = new Point(1043, 77);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(40, 38);
            btnReload.TabIndex = 3;
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnUpdate.IconColor = Color.Black;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.IconSize = 38;
            btnUpdate.Location = new Point(1098, 77);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(40, 38);
            btnUpdate.TabIndex = 4;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashCan;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 34;
            btnDelete.Location = new Point(1153, 77);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(40, 38);
            btnDelete.TabIndex = 5;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1317, 754);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnReload);
            Controls.Add(label1);
            Controls.Add(dtTalents);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Talent Manager";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtTalents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem talentosToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem tsActualizar;
        private DataGridView dtTalents;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnReload;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
    }
}
