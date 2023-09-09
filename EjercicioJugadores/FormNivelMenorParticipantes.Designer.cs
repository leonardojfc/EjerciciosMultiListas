namespace EjercicioJugadores
{
    partial class FormNivelMenorParticipantes
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
            this.dgvNivelMenorCantidadParticipantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivelMenorCantidadParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(189, 46);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(414, 25);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Niveles con la menor cantidad de participantes";
            // 
            // dgvNivelMenorCantidadParticipantes
            // 
            this.dgvNivelMenorCantidadParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNivelMenorCantidadParticipantes.Location = new System.Drawing.Point(51, 103);
            this.dgvNivelMenorCantidadParticipantes.Name = "dgvNivelMenorCantidadParticipantes";
            this.dgvNivelMenorCantidadParticipantes.RowHeadersWidth = 51;
            this.dgvNivelMenorCantidadParticipantes.RowTemplate.Height = 24;
            this.dgvNivelMenorCantidadParticipantes.Size = new System.Drawing.Size(686, 314);
            this.dgvNivelMenorCantidadParticipantes.TabIndex = 1;
            // 
            // FormNivelMenorParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvNivelMenorCantidadParticipantes);
            this.Controls.Add(this.lblTittle);
            this.Name = "FormNivelMenorParticipantes";
            this.Text = "FormNivelMenorParticipantes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNivelMenorParticipantes_FormClosed);
            this.Load += new System.EventHandler(this.FormNivelMenorParticipantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivelMenorCantidadParticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.DataGridView dgvNivelMenorCantidadParticipantes;
    }
}