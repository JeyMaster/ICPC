namespace Vistas
{
    partial class FrmTableroAdministrador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdminInstituciones = new System.Windows.Forms.Button();
            this.btnAdminConcursos = new System.Windows.Forms.Button();
            this.btnAdminSedes = new System.Windows.Forms.Button();
            this.btnAdminRegiones = new System.Windows.Forms.Button();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAdminInstituciones);
            this.panel1.Controls.Add(this.btnAdminConcursos);
            this.panel1.Controls.Add(this.btnAdminSedes);
            this.panel1.Controls.Add(this.btnAdminRegiones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 511);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenido \"Administrador\"";
            // 
            // btnAdminInstituciones
            // 
            this.btnAdminInstituciones.Location = new System.Drawing.Point(8, 189);
            this.btnAdminInstituciones.Name = "btnAdminInstituciones";
            this.btnAdminInstituciones.Size = new System.Drawing.Size(133, 43);
            this.btnAdminInstituciones.TabIndex = 3;
            this.btnAdminInstituciones.Text = "Instituciones";
            this.btnAdminInstituciones.UseVisualStyleBackColor = true;
            this.btnAdminInstituciones.Click += new System.EventHandler(this.btnAdminInstituciones_Click);
            // 
            // btnAdminConcursos
            // 
            this.btnAdminConcursos.Location = new System.Drawing.Point(8, 140);
            this.btnAdminConcursos.Name = "btnAdminConcursos";
            this.btnAdminConcursos.Size = new System.Drawing.Size(133, 43);
            this.btnAdminConcursos.TabIndex = 2;
            this.btnAdminConcursos.Text = "Concursos";
            this.btnAdminConcursos.UseVisualStyleBackColor = true;
            this.btnAdminConcursos.Click += new System.EventHandler(this.btnAdminConcursos_Click);
            // 
            // btnAdminSedes
            // 
            this.btnAdminSedes.Location = new System.Drawing.Point(8, 91);
            this.btnAdminSedes.Name = "btnAdminSedes";
            this.btnAdminSedes.Size = new System.Drawing.Size(133, 43);
            this.btnAdminSedes.TabIndex = 1;
            this.btnAdminSedes.Text = "Sedes";
            this.btnAdminSedes.UseVisualStyleBackColor = true;
            this.btnAdminSedes.Click += new System.EventHandler(this.btnAdminSedes_Click);
            // 
            // btnAdminRegiones
            // 
            this.btnAdminRegiones.Location = new System.Drawing.Point(8, 42);
            this.btnAdminRegiones.Name = "btnAdminRegiones";
            this.btnAdminRegiones.Size = new System.Drawing.Size(133, 43);
            this.btnAdminRegiones.TabIndex = 0;
            this.btnAdminRegiones.Text = "Regiones";
            this.btnAdminRegiones.UseVisualStyleBackColor = true;
            this.btnAdminRegiones.Click += new System.EventHandler(this.btnAdminRegiones_Click);
            // 
            // pnContenedor
            // 
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(150, 0);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(784, 511);
            this.pnContenedor.TabIndex = 1;
            // 
            // FrmTableroAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "FrmTableroAdministrador";
            this.Text = "FrmTableroAdministrador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminInstituciones;
        private System.Windows.Forms.Button btnAdminConcursos;
        private System.Windows.Forms.Button btnAdminSedes;
        private System.Windows.Forms.Button btnAdminRegiones;
    }
}