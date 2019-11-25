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
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Selecionar Region: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(296, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Seleccionar Sede:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Seleccionar Concurso: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(296, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Seleccionar Institución:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(12, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(211, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ingresa El nombre del equipo";
			// 
			// btnAgregarIntegrante
			// 
			this.btnAgregarIntegrante.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnAgregarIntegrante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.btnAgregarIntegrante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregarIntegrante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarIntegrante.ForeColor = System.Drawing.Color.White;
			this.btnAgregarIntegrante.Location = new System.Drawing.Point(351, 162);
			this.btnAgregarIntegrante.Name = "btnAgregarIntegrante";
			this.btnAgregarIntegrante.Size = new System.Drawing.Size(190, 35);
			this.btnAgregarIntegrante.TabIndex = 8;
			this.btnAgregarIntegrante.Text = "Agregar Integrante";
			this.btnAgregarIntegrante.UseVisualStyleBackColor = true;
			// 
			// dgvIntegrantes
			// 
			this.dgvIntegrantes.BackgroundColor = System.Drawing.Color.BlueViolet;
			this.dgvIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvIntegrantes.GridColor = System.Drawing.Color.BlueViolet;
			this.dgvIntegrantes.Location = new System.Drawing.Point(15, 236);
			this.dgvIntegrantes.Name = "dgvIntegrantes";
			this.dgvIntegrantes.Size = new System.Drawing.Size(561, 179);
			this.dgvIntegrantes.TabIndex = 9;
			// 
			// btnCancelar
			// 
			this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.White;
			this.btnCancelar.Location = new System.Drawing.Point(15, 432);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(132, 32);
			this.btnCancelar.TabIndex = 10;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnAgregar
			// 
			this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.Color.White;
			this.btnAgregar.Location = new System.Drawing.Point(443, 432);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(133, 32);
			this.btnAgregar.TabIndex = 11;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			// 
			// cbRegiones
			// 
			this.cbRegiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRegiones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRegiones.ForeColor = System.Drawing.Color.Black;
			this.cbRegiones.FormattingEnabled = true;
			this.cbRegiones.Location = new System.Drawing.Point(15, 30);
			this.cbRegiones.Name = "cbRegiones";
			this.cbRegiones.Size = new System.Drawing.Size(259, 26);
			this.cbRegiones.TabIndex = 12;
			this.cbRegiones.SelectedIndexChanged += new System.EventHandler(this.cbRegiones_SelectedIndexChanged);
			// 
			// cbSedes
			// 
			this.cbSedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSedes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSedes.ForeColor = System.Drawing.Color.Black;
			this.cbSedes.FormattingEnabled = true;
			this.cbSedes.Location = new System.Drawing.Point(299, 30);
			this.cbSedes.Name = "cbSedes";
			this.cbSedes.Size = new System.Drawing.Size(277, 26);
			this.cbSedes.TabIndex = 13;
			this.cbSedes.SelectedIndexChanged += new System.EventHandler(this.cbSedes_SelectedIndexChanged);
			// 
			// cbConcursos
			// 
			this.cbConcursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbConcursos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbConcursos.ForeColor = System.Drawing.Color.Black;
			this.cbConcursos.FormattingEnabled = true;
			this.cbConcursos.Location = new System.Drawing.Point(15, 96);
			this.cbConcursos.Name = "cbConcursos";
			this.cbConcursos.Size = new System.Drawing.Size(259, 26);
			this.cbConcursos.TabIndex = 14;
			// 
			// cbInstituciones
			// 
			this.cbInstituciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbInstituciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbInstituciones.ForeColor = System.Drawing.Color.Black;
			this.cbInstituciones.FormattingEnabled = true;
			this.cbInstituciones.Location = new System.Drawing.Point(299, 96);
			this.cbInstituciones.Name = "cbInstituciones";
			this.cbInstituciones.Size = new System.Drawing.Size(277, 26);
			this.cbInstituciones.TabIndex = 15;
			// 
			// txtNombreEquipo
			// 
			this.txtNombreEquipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreEquipo.ForeColor = System.Drawing.Color.Black;
			this.txtNombreEquipo.Location = new System.Drawing.Point(12, 167);
			this.txtNombreEquipo.Name = "txtNombreEquipo";
			this.txtNombreEquipo.Size = new System.Drawing.Size(262, 26);
			this.txtNombreEquipo.TabIndex = 16;
			// 
			// FrmCrearEquipo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MidnightBlue;
			this.ClientSize = new System.Drawing.Size(594, 476);
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
			this.Load += new System.EventHandler(this.FrmCrearEquipo_Load);
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