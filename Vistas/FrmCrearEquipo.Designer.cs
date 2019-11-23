namespace Vistas
{
    partial class FrmCrearEquipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarIntegrante = new System.Windows.Forms.Button();
            this.dgvIntegrantes = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbRegiones = new System.Windows.Forms.ComboBox();
            this.cbSedes = new System.Windows.Forms.ComboBox();
            this.cbConcursos = new System.Windows.Forms.ComboBox();
            this.cbInstituciones = new System.Windows.Forms.ComboBox();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecionar Region: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccionar Sede:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccionar Concurso: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seleccionar Institución:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingresa El nombre del equipo";
            // 
            // btnAgregarIntegrante
            // 
            this.btnAgregarIntegrante.Location = new System.Drawing.Point(15, 227);
            this.btnAgregarIntegrante.Name = "btnAgregarIntegrante";
            this.btnAgregarIntegrante.Size = new System.Drawing.Size(190, 23);
            this.btnAgregarIntegrante.TabIndex = 8;
            this.btnAgregarIntegrante.Text = "Agregar Integrante";
            this.btnAgregarIntegrante.UseVisualStyleBackColor = true;
            // 
            // dgvIntegrantes
            // 
            this.dgvIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntegrantes.Location = new System.Drawing.Point(15, 256);
            this.dgvIntegrantes.Name = "dgvIntegrantes";
            this.dgvIntegrantes.Size = new System.Drawing.Size(190, 179);
            this.dgvIntegrantes.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(15, 441);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(130, 441);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cbRegiones
            // 
            this.cbRegiones.FormattingEnabled = true;
            this.cbRegiones.Location = new System.Drawing.Point(15, 25);
            this.cbRegiones.Name = "cbRegiones";
            this.cbRegiones.Size = new System.Drawing.Size(190, 21);
            this.cbRegiones.TabIndex = 12;
            // 
            // cbSedes
            // 
            this.cbSedes.FormattingEnabled = true;
            this.cbSedes.Location = new System.Drawing.Point(15, 71);
            this.cbSedes.Name = "cbSedes";
            this.cbSedes.Size = new System.Drawing.Size(190, 21);
            this.cbSedes.TabIndex = 13;
            // 
            // cbConcursos
            // 
            this.cbConcursos.FormattingEnabled = true;
            this.cbConcursos.Location = new System.Drawing.Point(15, 111);
            this.cbConcursos.Name = "cbConcursos";
            this.cbConcursos.Size = new System.Drawing.Size(190, 21);
            this.cbConcursos.TabIndex = 14;
            // 
            // cbInstituciones
            // 
            this.cbInstituciones.FormattingEnabled = true;
            this.cbInstituciones.Location = new System.Drawing.Point(15, 152);
            this.cbInstituciones.Name = "cbInstituciones";
            this.cbInstituciones.Size = new System.Drawing.Size(190, 21);
            this.cbInstituciones.TabIndex = 15;
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(15, 192);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(190, 20);
            this.txtNombreEquipo.TabIndex = 16;
            // 
            // FrmCrearEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 476);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.cbInstituciones);
            this.Controls.Add(this.cbConcursos);
            this.Controls.Add(this.cbSedes);
            this.Controls.Add(this.cbRegiones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvIntegrantes);
            this.Controls.Add(this.btnAgregarIntegrante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearEquipo";
            this.Text = "FrmCrearEquipo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarIntegrante;
        private System.Windows.Forms.DataGridView dgvIntegrantes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbRegiones;
        private System.Windows.Forms.ComboBox cbSedes;
        private System.Windows.Forms.ComboBox cbConcursos;
        private System.Windows.Forms.ComboBox cbInstituciones;
        private System.Windows.Forms.TextBox txtNombreEquipo;
    }
}