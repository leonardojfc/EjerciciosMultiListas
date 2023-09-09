namespace EjercicioPeliculas
{
    partial class FormReporte1
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
            this.chkGenero = new System.Windows.Forms.CheckBox();
            this.chkDuracion = new System.Windows.Forms.CheckBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(309, 30);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(161, 25);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Lista de peliculas";
            // 
            // chkGenero
            // 
            this.chkGenero.AutoSize = true;
            this.chkGenero.Location = new System.Drawing.Point(464, 96);
            this.chkGenero.Name = "chkGenero";
            this.chkGenero.Size = new System.Drawing.Size(98, 20);
            this.chkGenero.TabIndex = 2;
            this.chkGenero.Text = "Por Genero";
            this.chkGenero.UseVisualStyleBackColor = true;
            this.chkGenero.CheckedChanged += new System.EventHandler(this.chkGenero_CheckedChanged);
            // 
            // chkDuracion
            // 
            this.chkDuracion.AutoSize = true;
            this.chkDuracion.Location = new System.Drawing.Point(464, 188);
            this.chkDuracion.Name = "chkDuracion";
            this.chkDuracion.Size = new System.Drawing.Size(107, 20);
            this.chkDuracion.TabIndex = 3;
            this.chkDuracion.Text = "Por Duracion";
            this.chkDuracion.UseVisualStyleBackColor = true;
            this.chkDuracion.CheckedChanged += new System.EventHandler(this.chkDuracion_CheckedChanged);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(464, 139);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 22);
            this.txtGenero.TabIndex = 4;
            this.txtGenero.TextChanged += new System.EventHandler(this.txtGenero_TextChanged);
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(21, 96);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.RowHeadersWidth = 51;
            this.dgvPeliculas.RowTemplate.Height = 24;
            this.dgvPeliculas.Size = new System.Drawing.Size(405, 296);
            this.dgvPeliculas.TabIndex = 5;
            // 
            // FormReporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.chkDuracion);
            this.Controls.Add(this.chkGenero);
            this.Controls.Add(this.lblTittle);
            this.Name = "FormReporte1";
            this.Text = "FormReporte1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReporte1_FormClosed);
            this.Load += new System.EventHandler(this.FormReporte1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.CheckBox chkGenero;
        private System.Windows.Forms.CheckBox chkDuracion;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.DataGridView dgvPeliculas;
    }
}