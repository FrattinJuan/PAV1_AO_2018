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
            this.btnListo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            this.dgvOdontologos.Location = new System.Drawing.Point(8, 8);
            this.dgvOdontologos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOdontologos.Name = "dgvOdontologos";
            this.dgvOdontologos.ReadOnly = true;
            this.dgvOdontologos.RowTemplate.Height = 28;
            this.dgvOdontologos.Size = new System.Drawing.Size(336, 227);
            this.dgvOdontologos.TabIndex = 0;
            this.dgvOdontologos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOdontologos_CellContentClick);
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
            // btnListo
            // 
            this.btnListo.Location = new System.Drawing.Point(43, 244);
            this.btnListo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(64, 28);
            this.btnListo.TabIndex = 2;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(222, 244);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BuscarOdontologos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(356, 293);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.dgvOdontologos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(372, 332);
            this.MinimumSize = new System.Drawing.Size(372, 332);
            this.Name = "BuscarOdontologos";
            this.Text = "BuscarOdontologos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuscarOdontologos_FormClosing);
            this.Load += new System.EventHandler(this.BuscarOdontologos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdontologos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOdontologos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_matricula;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Button btnCancelar;
    }
}