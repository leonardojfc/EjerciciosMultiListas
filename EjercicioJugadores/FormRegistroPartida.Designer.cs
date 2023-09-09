namespace EjercicioJugadores
{
    partial class FormRegistroPartida
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblColorPrimerParticipante = new System.Windows.Forms.Label();
            this.lblColorParticipanteSegundo = new System.Windows.Forms.Label();
            this.lblGanador = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbColorPrimerParticipante = new System.Windows.Forms.ComboBox();
            this.cmbColorSegundoParticipante = new System.Windows.Forms.ComboBox();
            this.cmbGanador = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(286, 19);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(174, 25);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Registro de partida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // lblColorPrimerParticipante
            // 
            this.lblColorPrimerParticipante.AutoSize = true;
            this.lblColorPrimerParticipante.Location = new System.Drawing.Point(75, 146);
            this.lblColorPrimerParticipante.Name = "lblColorPrimerParticipante";
            this.lblColorPrimerParticipante.Size = new System.Drawing.Size(178, 16);
            this.lblColorPrimerParticipante.TabIndex = 2;
            this.lblColorPrimerParticipante.Text = "Color del primer participante:";
            // 
            // lblColorParticipanteSegundo
            // 
            this.lblColorParticipanteSegundo.AutoSize = true;
            this.lblColorParticipanteSegundo.Location = new System.Drawing.Point(60, 208);
            this.lblColorParticipanteSegundo.Name = "lblColorParticipanteSegundo";
            this.lblColorParticipanteSegundo.Size = new System.Drawing.Size(193, 16);
            this.lblColorParticipanteSegundo.TabIndex = 3;
            this.lblColorParticipanteSegundo.Text = "Color del segundo participante:";
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Location = new System.Drawing.Point(112, 269);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(141, 16);
            this.lblGanador.TabIndex = 4;
            this.lblGanador.Text = "Ganador de la partida:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(405, 99);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(159, 22);
            this.txtCodigo.TabIndex = 5;
            // 
            // cmbColorPrimerParticipante
            // 
            this.cmbColorPrimerParticipante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorPrimerParticipante.FormattingEnabled = true;
            this.cmbColorPrimerParticipante.Items.AddRange(new object[] {
            "Negras",
            "Blancas"});
            this.cmbColorPrimerParticipante.Location = new System.Drawing.Point(405, 146);
            this.cmbColorPrimerParticipante.Name = "cmbColorPrimerParticipante";
            this.cmbColorPrimerParticipante.Size = new System.Drawing.Size(159, 24);
            this.cmbColorPrimerParticipante.TabIndex = 6;
            this.cmbColorPrimerParticipante.SelectedIndexChanged += new System.EventHandler(this.cmbColorPrimerParticipante_SelectedIndexChanged);
            // 
            // cmbColorSegundoParticipante
            // 
            this.cmbColorSegundoParticipante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorSegundoParticipante.FormattingEnabled = true;
            this.cmbColorSegundoParticipante.Items.AddRange(new object[] {
            "Negras",
            "Blancas"});
            this.cmbColorSegundoParticipante.Location = new System.Drawing.Point(405, 208);
            this.cmbColorSegundoParticipante.Name = "cmbColorSegundoParticipante";
            this.cmbColorSegundoParticipante.Size = new System.Drawing.Size(159, 24);
            this.cmbColorSegundoParticipante.TabIndex = 7;
            this.cmbColorSegundoParticipante.SelectedIndexChanged += new System.EventHandler(this.cmbColorSegundoParticipante_SelectedIndexChanged);
            // 
            // cmbGanador
            // 
            this.cmbGanador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGanador.FormattingEnabled = true;
            this.cmbGanador.Items.AddRange(new object[] {
            "Negras",
            "Blancas",
            "Empate"});
            this.cmbGanador.Location = new System.Drawing.Point(405, 269);
            this.cmbGanador.Name = "cmbGanador";
            this.cmbGanador.Size = new System.Drawing.Size(159, 24);
            this.cmbGanador.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(310, 364);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(114, 29);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FormRegistroPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbGanador);
            this.Controls.Add(this.cmbColorSegundoParticipante);
            this.Controls.Add(this.cmbColorPrimerParticipante);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.lblColorParticipanteSegundo);
            this.Controls.Add(this.lblColorPrimerParticipante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTittle);
            this.Name = "FormRegistroPartida";
            this.Text = "FormRegistroPartida";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegistroPartida_FormClosed);
            this.Load += new System.EventHandler(this.FormRegistroPartida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblColorPrimerParticipante;
        private System.Windows.Forms.Label lblColorParticipanteSegundo;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbColorPrimerParticipante;
        private System.Windows.Forms.ComboBox cmbColorSegundoParticipante;
        private System.Windows.Forms.ComboBox cmbGanador;
        private System.Windows.Forms.Button btnRegistrar;
    }
}