namespace EjercicioJugadores
{
    partial class FormRegistroParticipante
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblAnioNacimiento = new System.Windows.Forms.Label();
            this.lblNivelJuego = new System.Windows.Forms.Label();
            this.cmbNivelJuego = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAnioNacimiento = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(299, 23);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(190, 25);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Registro Participante";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(130, 91);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 16);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(130, 137);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(130, 186);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(96, 16);
            this.lblDepartamento.TabIndex = 3;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblAnioNacimiento
            // 
            this.lblAnioNacimiento.AutoSize = true;
            this.lblAnioNacimiento.Location = new System.Drawing.Point(130, 238);
            this.lblAnioNacimiento.Name = "lblAnioNacimiento";
            this.lblAnioNacimiento.Size = new System.Drawing.Size(121, 16);
            this.lblAnioNacimiento.TabIndex = 4;
            this.lblAnioNacimiento.Text = "Año de nacimiento:";
            // 
            // lblNivelJuego
            // 
            this.lblNivelJuego.AutoSize = true;
            this.lblNivelJuego.Location = new System.Drawing.Point(130, 291);
            this.lblNivelJuego.Name = "lblNivelJuego";
            this.lblNivelJuego.Size = new System.Drawing.Size(97, 16);
            this.lblNivelJuego.TabIndex = 5;
            this.lblNivelJuego.Text = "Nivel de juego:";
            // 
            // cmbNivelJuego
            // 
            this.cmbNivelJuego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelJuego.FormattingEnabled = true;
            this.cmbNivelJuego.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNivelJuego.Location = new System.Drawing.Point(368, 291);
            this.cmbNivelJuego.Name = "cmbNivelJuego";
            this.cmbNivelJuego.Size = new System.Drawing.Size(148, 24);
            this.cmbNivelJuego.TabIndex = 6;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Items.AddRange(new object[] {
            "Lima",
            "Loreto",
            "Arequipa",
            "Piura"});
            this.cmbDepartamento.Location = new System.Drawing.Point(368, 186);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(148, 24);
            this.cmbDepartamento.TabIndex = 7;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(368, 91);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(148, 22);
            this.txtDNI.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(368, 137);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // txtAnioNacimiento
            // 
            this.txtAnioNacimiento.Location = new System.Drawing.Point(368, 238);
            this.txtAnioNacimiento.Name = "txtAnioNacimiento";
            this.txtAnioNacimiento.Size = new System.Drawing.Size(148, 22);
            this.txtAnioNacimiento.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(328, 363);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(102, 30);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FormRegistroParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtAnioNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.cmbNivelJuego);
            this.Controls.Add(this.lblNivelJuego);
            this.Controls.Add(this.lblAnioNacimiento);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblTittle);
            this.Name = "FormRegistroParticipante";
            this.Text = "RegistroParticipante";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegistroParticipante_FormClosed);
            this.Load += new System.EventHandler(this.FormRegistroParticipante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblAnioNacimiento;
        private System.Windows.Forms.Label lblNivelJuego;
        private System.Windows.Forms.ComboBox cmbNivelJuego;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAnioNacimiento;
        private System.Windows.Forms.Button btnRegistrar;
    }
}