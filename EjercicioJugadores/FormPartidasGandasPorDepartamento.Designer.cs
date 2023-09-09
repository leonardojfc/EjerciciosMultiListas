namespace EjercicioJugadores
{
    partial class FormPartidasGandasPorDepartamento
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
            this.dgvPartidasGanadasPorDepartamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidasGanadasPorDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(240, 29);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(322, 25);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Partidas ganadas por departamento";
            // 
            // dgvPartidasGanadasPorDepartamento
            // 
            this.dgvPartidasGanadasPorDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidasGanadasPorDepartamento.Location = new System.Drawing.Point(50, 78);
            this.dgvPartidasGanadasPorDepartamento.Name = "dgvPartidasGanadasPorDepartamento";
            this.dgvPartidasGanadasPorDepartamento.RowHeadersWidth = 51;
            this.dgvPartidasGanadasPorDepartamento.RowTemplate.Height = 24;
            this.dgvPartidasGanadasPorDepartamento.Size = new System.Drawing.Size(685, 322);
            this.dgvPartidasGanadasPorDepartamento.TabIndex = 1;
            // 
            // FormPartidasGandasPorDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPartidasGanadasPorDepartamento);
            this.Controls.Add(this.lblTittle);
            this.Name = "FormPartidasGandasPorDepartamento";
            this.Text = "FormPartidasGandasPorDepartamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPartidasGandasPorDepartamento_FormClosed);
            this.Load += new System.EventHandler(this.FormPartidasGandasPorDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidasGanadasPorDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.DataGridView dgvPartidasGanadasPorDepartamento;
    }
}