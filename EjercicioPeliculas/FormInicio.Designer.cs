namespace EjercicioPeliculas
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrarDirector = new System.Windows.Forms.Button();
            this.cmbDirectores = new System.Windows.Forms.ComboBox();
            this.btnReporte1 = new System.Windows.Forms.Button();
            this.btnRegistrarPelicula = new System.Windows.Forms.Button();
            this.lblReportes = new System.Windows.Forms.Label();
            this.btnReporte2 = new System.Windows.Forms.Button();
            this.btnReporte3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarDirector
            // 
            this.btnRegistrarDirector.Location = new System.Drawing.Point(37, 21);
            this.btnRegistrarDirector.Name = "btnRegistrarDirector";
            this.btnRegistrarDirector.Size = new System.Drawing.Size(148, 34);
            this.btnRegistrarDirector.TabIndex = 0;
            this.btnRegistrarDirector.Text = "Registrar Director";
            this.btnRegistrarDirector.UseVisualStyleBackColor = true;
            this.btnRegistrarDirector.Click += new System.EventHandler(this.btnRegistrarDirector_Click);
            // 
            // cmbDirectores
            // 
            this.cmbDirectores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirectores.FormattingEnabled = true;
            this.cmbDirectores.Location = new System.Drawing.Point(470, 27);
            this.cmbDirectores.Name = "cmbDirectores";
            this.cmbDirectores.Size = new System.Drawing.Size(226, 24);
            this.cmbDirectores.TabIndex = 1;
            // 
            // btnReporte1
            // 
            this.btnReporte1.Location = new System.Drawing.Point(70, 250);
            this.btnReporte1.Name = "btnReporte1";
            this.btnReporte1.Size = new System.Drawing.Size(85, 31);
            this.btnReporte1.TabIndex = 2;
            this.btnReporte1.Text = "Reporte 1";
            this.btnReporte1.UseVisualStyleBackColor = true;
            this.btnReporte1.Click += new System.EventHandler(this.btnReporte1_Click);
            // 
            // btnRegistrarPelicula
            // 
            this.btnRegistrarPelicula.Location = new System.Drawing.Point(37, 104);
            this.btnRegistrarPelicula.Name = "btnRegistrarPelicula";
            this.btnRegistrarPelicula.Size = new System.Drawing.Size(148, 35);
            this.btnRegistrarPelicula.TabIndex = 3;
            this.btnRegistrarPelicula.Text = "Registrar Pelicula";
            this.btnRegistrarPelicula.UseVisualStyleBackColor = true;
            this.btnRegistrarPelicula.Click += new System.EventHandler(this.btnRegistrarPelicula_Click);
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.Location = new System.Drawing.Point(335, 186);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(90, 25);
            this.lblReportes.TabIndex = 4;
            this.lblReportes.Text = "Reportes";
            // 
            // btnReporte2
            // 
            this.btnReporte2.Location = new System.Drawing.Point(340, 250);
            this.btnReporte2.Name = "btnReporte2";
            this.btnReporte2.Size = new System.Drawing.Size(85, 31);
            this.btnReporte2.TabIndex = 5;
            this.btnReporte2.Text = "Reporte 2";
            this.btnReporte2.UseVisualStyleBackColor = true;
            this.btnReporte2.Click += new System.EventHandler(this.btnReporte2_Click);
            // 
            // btnReporte3
            // 
            this.btnReporte3.Location = new System.Drawing.Point(611, 250);
            this.btnReporte3.Name = "btnReporte3";
            this.btnReporte3.Size = new System.Drawing.Size(85, 31);
            this.btnReporte3.TabIndex = 6;
            this.btnReporte3.Text = "Reporte 3";
            this.btnReporte3.UseVisualStyleBackColor = true;
            this.btnReporte3.Click += new System.EventHandler(this.btnReporte3_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporte3);
            this.Controls.Add(this.btnReporte2);
            this.Controls.Add(this.lblReportes);
            this.Controls.Add(this.btnRegistrarPelicula);
            this.Controls.Add(this.btnReporte1);
            this.Controls.Add(this.cmbDirectores);
            this.Controls.Add(this.btnRegistrarDirector);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarDirector;
        private System.Windows.Forms.ComboBox cmbDirectores;
        private System.Windows.Forms.Button btnReporte1;
        private System.Windows.Forms.Button btnRegistrarPelicula;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Button btnReporte2;
        private System.Windows.Forms.Button btnReporte3;
    }
}

