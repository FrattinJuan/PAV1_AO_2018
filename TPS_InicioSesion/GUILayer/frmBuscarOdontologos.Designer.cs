namespace PAV1_AO_2018
{
    partial class BuscarOdontologos
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
            this.dgvOdontologos = new System.Windows.Forms.DataGridView();
            this.col_idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdontologos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOdontologos
            // 
            this.dgvOdontologos.AllowUserToAddRows = false;
            this.dgvOdontologos.AllowUserToDeleteRows = false;
            this.dgvOdontologos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdontologos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_idUsuario,
            this.col_nombre,
            this.col_matricula});
            this.dgvOdontologos.Location = new System.Drawing.Point(12, 12);
            this.dgvOdontologos.Name = "dgvOdontologos";
            this.dgvOdontologos.ReadOnly = true;
            this.dgvOdontologos.RowTemplate.Height = 28;
            this.dgvOdontologos.Size = new System.Drawing.Size(345, 372);
            this.dgvOdontologos.TabIndex = 0;
            // 
            // col_idUsuario
            // 
            this.col_idUsuario.HeaderText = "ID";
            this.col_idUsuario.Name = "col_idUsuario";
            this.col_idUsuario.ReadOnly = true;
            // 
            // col_nombre
            // 
            this.col_nombre.HeaderText = "Nombre ";
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.ReadOnly = true;
            // 
            // col_matricula
            // 
            this.col_matricula.HeaderText = "Matricula";
            this.col_matricula.Name = "col_matricula";
            this.col_matricula.ReadOnly = true;
            // 
            // BuscarOdontologos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(363, 395);
            this.Controls.Add(this.dgvOdontologos);
            this.Name = "BuscarOdontologos";
            this.Text = "BuscarOdontologos";
            this.Load += new System.EventHandler(this.BuscarOdontologos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdontologos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOdontologos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_matricula;
    }
}