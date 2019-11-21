namespace Vistas
{
    partial class FrmTableroMiembro
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnAdminEquipos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearEquipo = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.btnAdminEquipos);
            this.pnMenu.Controls.Add(this.label1);
            this.pnMenu.Controls.Add(this.btnCrearEquipo);
            this.pnMenu.Controls.Add(this.btnPerfil);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(129, 511);
            this.pnMenu.TabIndex = 0;
            // 
            // btnAdminEquipos
            // 
            this.btnAdminEquipos.Location = new System.Drawing.Point(10, 122);
            this.btnAdminEquipos.Name = "btnAdminEquipos";
            this.btnAdminEquipos.Size = new System.Drawing.Size(108, 37);
            this.btnAdminEquipos.TabIndex = 3;
            this.btnAdminEquipos.Text = "Administrar Equipos";
            this.btnAdminEquipos.UseVisualStyleBackColor = true;
            this.btnAdminEquipos.Click += new System.EventHandler(this.btnAdminEquipos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido \"Miembro\"";
            // 
            // btnCrearEquipo
            // 
            this.btnCrearEquipo.Location = new System.Drawing.Point(10, 79);
            this.btnCrearEquipo.Name = "btnCrearEquipo";
            this.btnCrearEquipo.Size = new System.Drawing.Size(110, 37);
            this.btnCrearEquipo.TabIndex = 1;
            this.btnCrearEquipo.Text = "Crear Equipo";
            this.btnCrearEquipo.UseVisualStyleBackColor = true;
            this.btnCrearEquipo.Click += new System.EventHandler(this.btnCrearEquipo_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(10, 36);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(110, 37);
            this.btnPerfil.TabIndex = 0;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // pnContenedor
            // 
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(129, 0);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(805, 511);
            this.pnContenedor.TabIndex = 1;
            // 
            // FrmTableroMiembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.pnMenu);
            this.Name = "FrmTableroMiembro";
            this.Text = "FrmTableroMiembro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTableroMiembro_FormClosed);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Button btnCrearEquipo;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminEquipos;
    }
}