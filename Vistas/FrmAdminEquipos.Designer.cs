namespace Vistas
{
    partial class FrmAdminEquipos
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
			this.button3 = new System.Windows.Forms.Button();
			this.Equipos = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(532, 396);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(173, 36);
			this.button3.TabIndex = 19;
			this.button3.Text = "Eliminar";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// Equipos
			// 
			this.Equipos.AutoSize = true;
			this.Equipos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Equipos.ForeColor = System.Drawing.Color.White;
			this.Equipos.Location = new System.Drawing.Point(31, 15);
			this.Equipos.Name = "Equipos";
			this.Equipos.Size = new System.Drawing.Size(85, 24);
			this.Equipos.TabIndex = 18;
			this.Equipos.Text = "Equipos";
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(347, 396);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(162, 37);
			this.button2.TabIndex = 17;
			this.button2.Text = "Guardar cambios";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.BlueViolet;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(35, 58);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(670, 319);
			this.dataGridView1.TabIndex = 15;
			// 
			// FrmAdminEquipos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MidnightBlue;
			this.ClientSize = new System.Drawing.Size(748, 457);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.Equipos);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmAdminEquipos";
			this.Text = "FrmAdminEquipos";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Equipos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}