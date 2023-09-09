namespace EjercicioJugadores
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
            this.btnParticipante = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblPrimerParticipante = new System.Windows.Forms.Label();
            this.cmbPrimerParticipante = new System.Windows.Forms.ComboBox();
            this.lblSegundoParticipante = new System.Windows.Forms.Label();
            this.cmbSegundoParticipante = new System.Windows.Forms.ComboBox();
            this.btnRegistrarPartida = new System.Windows.Forms.Button();
            this.btnPartidasGanadasPorDepartamento = new System.Windows.Forms.Button();
            this.btnListaParticipantesMayorEdad = new System.Windows.Forms.Button();
            this.btnListaParticipantesMayorPartidaColor = new System.Windows.Forms.Button();
            this.btnNivelMenorCantidadParticipantes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnParticipante
            // 
            this.btnParticipante.Location = new System.Drawing.Point(42, 55);
            this.btnParticipante.Name = "btnParticipante";
            this.btnParticipante.Size = new System.Drawing.Size(156, 28);
            this.btnParticipante.TabIndex = 0;
            this.btnParticipante.Text = "Registrar Participante";
            this.btnParticipante.UseVisualStyleBackColor = true;
            this.btnParticipante.Click += new System.EventHandler(this.btnParticipante_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(347, 9);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(57, 25);
            this.lblTittle.TabIndex = 1;
            this.lblTittle.Text = "Inicio";
            // 
            // lblPrimerParticipante
            // 
            this.lblPrimerParticipante.AutoSize = true;
            this.lblPrimerParticipante.Location = new System.Drawing.Point(349, 61);
            this.lblPrimerParticipante.Name = "lblPrimerParticipante";
            this.lblPrimerParticipante.Size = new System.Drawing.Size(126, 16);
            this.lblPrimerParticipante.TabIndex = 2;
            this.lblPrimerParticipante.Text = "Primer Participante: ";
            // 
            // cmbPrimerParticipante
            // 
            this.cmbPrimerParticipante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrimerParticipante.FormattingEnabled = true;
            this.cmbPrimerParticipante.Location = new System.Drawing.Point(557, 58);
            this.cmbPrimerParticipante.Name = "cmbPrimerParticipante";
            this.cmbPrimerParticipante.Size = new System.Drawing.Size(154, 24);
            this.cmbPrimerParticipante.TabIndex = 3;
            this.cmbPrimerParticipante.SelectedIndexChanged += new System.EventHandler(this.cmbPrimerParticipante_SelectedIndexChanged);
            // 
            // lblSegundoParticipante
            // 
            this.lblSegundoParticipante.AutoSize = true;
            this.lblSegundoParticipante.Location = new System.Drawing.Point(349, 126);
            this.lblSegundoParticipante.Name = "lblSegundoParticipante";
            this.lblSegundoParticipante.Size = new System.Drawing.Size(142, 16);
            this.lblSegundoParticipante.TabIndex = 4;
            this.lblSegundoParticipante.Text = "Segundo Participante: ";
            // 
            // cmbSegundoParticipante
            // 
            this.cmbSegundoParticipante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSegundoParticipante.FormattingEnabled = true;
            this.cmbSegundoParticipante.Location = new System.Drawing.Point(557, 126);
            this.cmbSegundoParticipante.Name = "cmbSegundoParticipante";
            this.cmbSegundoParticipante.Size = new System.Drawing.Size(154, 24);
            this.cmbSegundoParticipante.TabIndex = 5;
            // 
            // btnRegistrarPartida
            // 
            this.btnRegistrarPartida.Location = new System.Drawing.Point(42, 126);
            this.btnRegistrarPartida.Name = "btnRegistrarPartida";
            this.btnRegistrarPartida.Size = new System.Drawing.Size(156, 28);
            this.btnRegistrarPartida.TabIndex = 6;
            this.btnRegistrarPartida.Text = "Registrar Partida";
            this.btnRegistrarPartida.UseVisualStyleBackColor = true;
            this.btnRegistrarPartida.Click += new System.EventHandler(this.btnRegistrarPartida_Click);
            // 
            // btnPartidasGanadasPorDepartamento
            // 
            this.btnPartidasGanadasPorDepartamento.Location = new System.Drawing.Point(567, 275);
            this.btnPartidasGanadasPorDepartamento.Name = "btnPartidasGanadasPorDepartamento";
            this.btnPartidasGanadasPorDepartamento.Size = new System.Drawing.Size(146, 51);
            this.btnPartidasGanadasPorDepartamento.TabIndex = 7;
            this.btnPartidasGanadasPorDepartamento.Text = "Partidas ganadas por departamento";
            this.btnPartidasGanadasPorDepartamento.UseVisualStyleBackColor = true;
            this.btnPartidasGanadasPorDepartamento.Click += new System.EventHandler(this.btnPartidasGanadasPorDepartamento_Click);
            // 
            // btnListaParticipantesMayorEdad
            // 
            this.btnListaParticipantesMayorEdad.Location = new System.Drawing.Point(68, 275);
            this.btnListaParticipantesMayorEdad.Name = "btnListaParticipantesMayorEdad";
            this.btnListaParticipantesMayorEdad.Size = new System.Drawing.Size(146, 51);
            this.btnListaParticipantesMayorEdad.TabIndex = 8;
            this.btnListaParticipantesMayorEdad.Text = "Listar participantes con la mayore dad";
            this.btnListaParticipantesMayorEdad.UseVisualStyleBackColor = true;
            this.btnListaParticipantesMayorEdad.Click += new System.EventHandler(this.btnListaParticipantesMayorEdad_Click);
            // 
            // btnListaParticipantesMayorPartidaColor
            // 
            this.btnListaParticipantesMayorPartidaColor.Location = new System.Drawing.Point(220, 267);
            this.btnListaParticipantesMayorPartidaColor.Name = "btnListaParticipantesMayorPartidaColor";
            this.btnListaParticipantesMayorPartidaColor.Size = new System.Drawing.Size(177, 67);
            this.btnListaParticipantesMayorPartidaColor.TabIndex = 9;
            this.btnListaParticipantesMayorPartidaColor.Text = "Lista participantes con la mayor cantidad de partidas por color";
            this.btnListaParticipantesMayorPartidaColor.UseVisualStyleBackColor = true;
            this.btnListaParticipantesMayorPartidaColor.Click += new System.EventHandler(this.btnListaParticipantesMayorPartidaColor_Click);
            // 
            // btnNivelMenorCantidadParticipantes
            // 
            this.btnNivelMenorCantidadParticipantes.Location = new System.Drawing.Point(403, 271);
            this.btnNivelMenorCantidadParticipantes.Name = "btnNivelMenorCantidadParticipantes";
            this.btnNivelMenorCantidadParticipantes.Size = new System.Drawing.Size(158, 59);
            this.btnNivelMenorCantidadParticipantes.TabIndex = 10;
            this.btnNivelMenorCantidadParticipantes.Text = "Niveles con la menor cantidad de participantes";
            this.btnNivelMenorCantidadParticipantes.UseVisualStyleBackColor = true;
            this.btnNivelMenorCantidadParticipantes.Click += new System.EventHandler(this.btnNivelMenorCantidadParticipantes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reportes";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNivelMenorCantidadParticipantes);
            this.Controls.Add(this.btnListaParticipantesMayorPartidaColor);
            this.Controls.Add(this.btnListaParticipantesMayorEdad);
            this.Controls.Add(this.btnPartidasGanadasPorDepartamento);
            this.Controls.Add(this.btnRegistrarPartida);
            this.Controls.Add(this.cmbSegundoParticipante);
            this.Controls.Add(this.lblSegundoParticipante);
            this.Controls.Add(this.cmbPrimerParticipante);
            this.Controls.Add(this.lblPrimerParticipante);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnParticipante);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParticipante;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblPrimerParticipante;
        private System.Windows.Forms.ComboBox cmbPrimerParticipante;
        private System.Windows.Forms.Label lblSegundoParticipante;
        private System.Windows.Forms.ComboBox cmbSegundoParticipante;
        private System.Windows.Forms.Button btnRegistrarPartida;
        private System.Windows.Forms.Button btnPartidasGanadasPorDepartamento;
        private System.Windows.Forms.Button btnListaParticipantesMayorEdad;
        private System.Windows.Forms.Button btnListaParticipantesMayorPartidaColor;
        private System.Windows.Forms.Button btnNivelMenorCantidadParticipantes;
        private System.Windows.Forms.Label label1;
    }
}

