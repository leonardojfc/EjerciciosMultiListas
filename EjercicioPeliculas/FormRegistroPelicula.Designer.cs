namespace EjercicioPeliculas
{
    partial class FormRegistroPelicula
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblAnioEstreno = new System.Windows.Forms.Label();
            this.lblTaquillaGenerada = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtTaquillaGenerada = new System.Windows.Forms.TextBox();
            this.txtAnioEstreno = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(81, 54);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(81, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(81, 157);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(52, 16);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Genero";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(81, 212);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(61, 16);
            this.lblDuracion.TabIndex = 3;
            this.lblDuracion.Text = "Duracion";
            // 
            // lblAnioEstreno
            // 
            this.lblAnioEstreno.AutoSize = true;
            this.lblAnioEstreno.Location = new System.Drawing.Point(81, 327);
            this.lblAnioEstreno.Name = "lblAnioEstreno";
            this.lblAnioEstreno.Size = new System.Drawing.Size(79, 16);
            this.lblAnioEstreno.TabIndex = 4;
            this.lblAnioEstreno.Text = "Año estreno";
            // 
            // lblTaquillaGenerada
            // 
            this.lblTaquillaGenerada.AutoSize = true;
            this.lblTaquillaGenerada.Location = new System.Drawing.Point(81, 272);
            this.lblTaquillaGenerada.Name = "lblTaquillaGenerada";
            this.lblTaquillaGenerada.Size = new System.Drawing.Size(118, 16);
            this.lblTaquillaGenerada.TabIndex = 5;
            this.lblTaquillaGenerada.Text = "Taquilla generada";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Terror",
            "Comedia",
            "Drama",
            "Ciencia Ficcion",
            "Anime"});
            this.cmbGenero.Location = new System.Drawing.Point(292, 157);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(184, 24);
            this.cmbGenero.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(292, 54);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(184, 22);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(292, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(292, 212);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(184, 22);
            this.txtDuracion.TabIndex = 9;
            // 
            // txtTaquillaGenerada
            // 
            this.txtTaquillaGenerada.Location = new System.Drawing.Point(292, 272);
            this.txtTaquillaGenerada.Name = "txtTaquillaGenerada";
            this.txtTaquillaGenerada.Size = new System.Drawing.Size(184, 22);
            this.txtTaquillaGenerada.TabIndex = 10;
            // 
            // txtAnioEstreno
            // 
            this.txtAnioEstreno.Location = new System.Drawing.Point(292, 327);
            this.txtAnioEstreno.Name = "txtAnioEstreno";
            this.txtAnioEstreno.Size = new System.Drawing.Size(184, 22);
            this.txtAnioEstreno.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(329, 376);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(95, 35);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(295, 9);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(181, 25);
            this.lblTittle.TabIndex = 13;
            this.lblTittle.Text = "Registro de pelicula";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(559, 199);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(189, 16);
            this.lblRespuesta.TabIndex = 14;
            this.lblRespuesta.Text = "Se ha registrado exitosamente";
            this.lblRespuesta.Visible = false;
            // 
            // FormRegistroPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtAnioEstreno);
            this.Controls.Add(this.txtTaquillaGenerada);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.lblTaquillaGenerada);
            this.Controls.Add(this.lblAnioEstreno);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FormRegistroPelicula";
            this.Text = "FormRegistrarPelicula";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegistroPelicula_FormClosed);
            this.Load += new System.EventHandler(this.FormRegistroPelicula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblAnioEstreno;
        private System.Windows.Forms.Label lblTaquillaGenerada;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtTaquillaGenerada;
        private System.Windows.Forms.TextBox txtAnioEstreno;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblRespuesta;
    }
}