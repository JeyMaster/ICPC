namespace Vistas
{
    partial class FrmAgregarEditarSedes
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
            this.lblIdSede = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdRegion = new System.Windows.Forms.Label();
            this.txtIdSede = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdRegion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdSede
            // 
            this.lblIdSede.AutoSize = true;
            this.lblIdSede.Location = new System.Drawing.Point(12, 9);
            this.lblIdSede.Name = "lblIdSede";
            this.lblIdSede.Size = new System.Drawing.Size(47, 13);
            this.lblIdSede.TabIndex = 0;
            this.lblIdSede.Text = "Id Sede:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblIdRegion
            // 
            this.lblIdRegion.AutoSize = true;
            this.lblIdRegion.Location = new System.Drawing.Point(143, 9);
            this.lblIdRegion.Name = "lblIdRegion";
            this.lblIdRegion.Size = new System.Drawing.Size(56, 13);
            this.lblIdRegion.TabIndex = 2;
            this.lblIdRegion.Text = "Id Region:";
            // 
            // txtIdSede
            // 
            this.txtIdSede.Location = new System.Drawing.Point(15, 25);
            this.txtIdSede.Name = "txtIdSede";
            this.txtIdSede.Size = new System.Drawing.Size(100, 20);
            this.txtIdSede.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtIdRegion
            // 
            this.txtIdRegion.Location = new System.Drawing.Point(146, 25);
            this.txtIdRegion.Name = "txtIdRegion";
            this.txtIdRegion.Size = new System.Drawing.Size(100, 20);
            this.txtIdRegion.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(15, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(146, 107);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(100, 23);
            this.btnGuardarCambios.TabIndex = 7;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // FrmAgregarEditarSedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 157);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtIdRegion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdSede);
            this.Controls.Add(this.lblIdRegion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdSede);
            this.Name = "FrmAgregarEditarSedes";
            this.Text = "Agregar Editar Sedes";
            this.Load += new System.EventHandler(this.FrmAgregarEditarSedes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdSede;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdRegion;
        private System.Windows.Forms.TextBox txtIdSede;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdRegion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarCambios;
    }
}