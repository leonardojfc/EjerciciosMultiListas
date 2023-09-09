namespace EjercicioJugadores
{
    partial class FormListaParticipantesMayorPartidaColor
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
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.dgvListaParticipantesMayorPartidasColor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaParticipantesMayorPartidasColor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(125, 29);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(551, 25);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Lista de participantes con mayor cantidad de partidas por color";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(100, 86);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(65, 25);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color:";
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Negras",
            "Blancas"});
            this.cmbColor.Location = new System.Drawing.Point(260, 90);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(124, 24);
            this.cmbColor.TabIndex = 2;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // dgvListaParticipantesMayorPartidasColor
            // 
            this.dgvListaParticipantesMayorPartidasColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaParticipantesMayorPartidasColor.Location = new System.Drawing.Point(41, 150);
            this.dgvListaParticipantesMayorPartidasColor.Name = "dgvListaParticipantesMayorPartidasColor";
            this.dgvListaParticipantesMayorPartidasColor.RowHeadersWidth = 51;
            this.dgvListaParticipantesMayorPartidasColor.RowTemplate.Height = 24;
            this.dgvListaParticipantesMayorPartidasColor.Size = new System.Drawing.Size(705, 266);
            this.dgvListaParticipantesMayorPartidasColor.TabIndex = 3;
            // 
            // FormListaParticipantesMayorPartidaColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListaParticipantesMayorPartidasColor);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblTittle);
            this.Name = "FormListaParticipantesMayorPartidaColor";
            this.Text = "FormListaParticipantesMayorPartidaColor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormListaParticipantesMayorPartidaColor_FormClosed);
            this.Load += new System.EventHandler(this.FormListaParticipantesMayorPartidaColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaParticipantesMayorPartidasColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.DataGridView dgvListaParticipantesMayorPartidasColor;
    }
}