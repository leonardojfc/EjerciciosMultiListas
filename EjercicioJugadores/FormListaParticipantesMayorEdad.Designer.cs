namespace EjercicioJugadores
{
    partial class FormListaParticipantesMayorEdad
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
            this.dgvListaParticipantesMayorEdad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaParticipantesMayorEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(234, 25);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(340, 25);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Lista de participantes con mayor edad";
            // 
            // dgvListaParticipantesMayorEdad
            // 
            this.dgvListaParticipantesMayorEdad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaParticipantesMayorEdad.Location = new System.Drawing.Point(50, 76);
            this.dgvListaParticipantesMayorEdad.Name = "dgvListaParticipantesMayorEdad";
            this.dgvListaParticipantesMayorEdad.RowHeadersWidth = 51;
            this.dgvListaParticipantesMayorEdad.RowTemplate.Height = 24;
            this.dgvListaParticipantesMayorEdad.Size = new System.Drawing.Size(692, 330);
            this.dgvListaParticipantesMayorEdad.TabIndex = 1;
            // 
            // FormListaParticipantesMayorEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListaParticipantesMayorEdad);
            this.Controls.Add(this.lblTittle);
            this.Name = "FormListaParticipantesMayorEdad";
            this.Text = "FormListaParticipantesMayorEdad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormListaParticipantesMayorEdad_FormClosed);
            this.Load += new System.EventHandler(this.FormListaParticipantesMayorEdad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaParticipantesMayorEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.DataGridView dgvListaParticipantesMayorEdad;
    }
}