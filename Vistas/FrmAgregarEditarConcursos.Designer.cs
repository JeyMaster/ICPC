namespace Vistas
{
    partial class FrmAgregarEditarConcursos
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
            this.components = new System.ComponentModel.Container();
            this.lblIdConcurso = new System.Windows.Forms.Label();
            this.lblIdSede = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdConcurso = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLocacion = new System.Windows.Forms.TextBox();
            this.txtInfoFacturacion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.errPConcurso = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbIdSede = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errPConcurso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdConcurso
            // 
            this.lblIdConcurso.AutoSize = true;
            this.lblIdConcurso.Location = new System.Drawing.Point(12, 9);
            this.lblIdConcurso.Name = "lblIdConcurso";
            this.lblIdConcurso.Size = new System.Drawing.Size(63, 13);
            this.lblIdConcurso.TabIndex = 0;
            this.lblIdConcurso.Text = "idConcurso:";
            // 
            // lblIdSede
            // 
            this.lblIdSede.AutoSize = true;
            this.lblIdSede.Location = new System.Drawing.Point(135, 9);
            this.lblIdSede.Name = "lblIdSede";
            this.lblIdSede.Size = new System.Drawing.Size(43, 13);
            this.lblIdSede.TabIndex = 1;
            this.lblIdSede.Text = "idSede:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Locacion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "infoFacturacion:";
            // 
            // txtIdConcurso
            // 
            this.txtIdConcurso.Location = new System.Drawing.Point(15, 25);
            this.txtIdConcurso.Name = "txtIdConcurso";
            this.txtIdConcurso.Size = new System.Drawing.Size(100, 20);
            this.txtIdConcurso.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(15, 73);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtLocacion
            // 
            this.txtLocacion.Location = new System.Drawing.Point(138, 123);
            this.txtLocacion.Name = "txtLocacion";
            this.txtLocacion.Size = new System.Drawing.Size(100, 20);
            this.txtLocacion.TabIndex = 6;
            // 
            // txtInfoFacturacion
            // 
            this.txtInfoFacturacion.Location = new System.Drawing.Point(16, 175);
            this.txtInfoFacturacion.Name = "txtInfoFacturacion";
            this.txtInfoFacturacion.Size = new System.Drawing.Size(100, 20);
            this.txtInfoFacturacion.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(15, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(138, 210);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(100, 23);
            this.btnGuardarCambios.TabIndex = 9;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // errPConcurso
            // 
            this.errPConcurso.ContainerControl = this;
            // 
            // cbIdSede
            // 
            this.cbIdSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdSede.FormattingEnabled = true;
            this.cbIdSede.Location = new System.Drawing.Point(138, 25);
            this.cbIdSede.Name = "cbIdSede";
            this.cbIdSede.Size = new System.Drawing.Size(121, 21);
            this.cbIdSede.TabIndex = 2;
            // 
            // FrmAgregarEditarConcursos
            // 
            this.AcceptButton = this.btnGuardarCambios;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 250);
            this.Controls.Add(this.cbIdSede);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtInfoFacturacion);
            this.Controls.Add(this.txtLocacion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtIdConcurso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIdSede);
            this.Controls.Add(this.lblIdConcurso);
            this.Name = "FrmAgregarEditarConcursos";
            this.Text = "AgregarEditarConcursos";
            this.Load += new System.EventHandler(this.FrmAgregarEditarConcursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errPConcurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdConcurso;
        private System.Windows.Forms.Label lblIdSede;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdConcurso;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLocacion;
        private System.Windows.Forms.TextBox txtInfoFacturacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.ErrorProvider errPConcurso;
        private System.Windows.Forms.ComboBox cbIdSede;
    }
}