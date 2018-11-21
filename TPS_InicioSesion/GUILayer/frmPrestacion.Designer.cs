namespace PAV1_AO_2018.GUILayer
{
    partial class frmPrestacion
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
            this.dgvPrestacion = new System.Windows.Forms.DataGridView();
            this.col_id_prestacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cod_prestacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblcodi = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtcodi = new System.Windows.Forms.TextBox();
            this.btnconsu = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.chktodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrestacion
            // 
            this.dgvPrestacion.AllowUserToAddRows = false;
            this.dgvPrestacion.AllowUserToDeleteRows = false;
            this.dgvPrestacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id_prestacion,
            this.col_nombre,
            this.col_cod_prestacion,
            this.col_descripcion});
            this.dgvPrestacion.Location = new System.Drawing.Point(-1, 118);
            this.dgvPrestacion.Name = "dgvPrestacion";
            this.dgvPrestacion.ReadOnly = true;
            this.dgvPrestacion.Size = new System.Drawing.Size(424, 179);
            this.dgvPrestacion.TabIndex = 0;
            this.dgvPrestacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // col_id_prestacion
            // 
            this.col_id_prestacion.HeaderText = "ID";
            this.col_id_prestacion.Name = "col_id_prestacion";
            this.col_id_prestacion.ReadOnly = true;
            // 
            // col_nombre
            // 
            this.col_nombre.HeaderText = "Nombre";
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.ReadOnly = true;
            // 
            // col_cod_prestacion
            // 
            this.col_cod_prestacion.HeaderText = "Codigo Prestacion";
            this.col_cod_prestacion.Name = "col_cod_prestacion";
            this.col_cod_prestacion.ReadOnly = true;
            // 
            // col_descripcion
            // 
            this.col_descripcion.HeaderText = "Descripciòn";
            this.col_descripcion.Name = "col_descripcion";
            this.col_descripcion.ReadOnly = true;
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.Location = new System.Drawing.Point(22, 27);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(54, 16);
            this.lblnom.TabIndex = 1;
            this.lblnom.Text = "Nombre:";
            // 
            // lblcodi
            // 
            this.lblcodi.AutoSize = true;
            this.lblcodi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodi.Location = new System.Drawing.Point(23, 64);
            this.lblcodi.Name = "lblcodi";
            this.lblcodi.Size = new System.Drawing.Size(51, 16);
            this.lblcodi.TabIndex = 2;
            this.lblcodi.Text = "Código:";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(75, 26);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 3;
            // 
            // txtcodi
            // 
            this.txtcodi.Location = new System.Drawing.Point(75, 62);
            this.txtcodi.Name = "txtcodi";
            this.txtcodi.Size = new System.Drawing.Size(100, 20);
            this.txtcodi.TabIndex = 4;
            // 
            // btnconsu
            // 
            this.btnconsu.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsu.Location = new System.Drawing.Point(213, 89);
            this.btnconsu.Name = "btnconsu";
            this.btnconsu.Size = new System.Drawing.Size(75, 23);
            this.btnconsu.TabIndex = 5;
            this.btnconsu.Text = "Consultar";
            this.btnconsu.UseVisualStyleBackColor = true;
            this.btnconsu.Click += new System.EventHandler(this.btnconsu_Click);
            // 
            // bteditar
            // 
            this.bteditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditar.Location = new System.Drawing.Point(191, 329);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(75, 23);
            this.bteditar.TabIndex = 6;
            this.bteditar.Text = "Editar";
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btnuevo
            // 
            this.btnuevo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuevo.Location = new System.Drawing.Point(87, 329);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnuevo.TabIndex = 7;
            this.btnuevo.Text = "Nuevo";
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminar.Location = new System.Drawing.Point(307, 329);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(75, 23);
            this.bteliminar.TabIndex = 8;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // chktodos
            // 
            this.chktodos.AutoSize = true;
            this.chktodos.Location = new System.Drawing.Point(119, 88);
            this.chktodos.Name = "chktodos";
            this.chktodos.Size = new System.Drawing.Size(56, 17);
            this.chktodos.TabIndex = 10;
            this.chktodos.Text = "Todos";
            this.chktodos.UseVisualStyleBackColor = true;
            this.chktodos.CheckedChanged += new System.EventHandler(this.chktodos_CheckedChanged);
            // 
            // frmPrestacion
            // 
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(687, 364);
            this.Controls.Add(this.chktodos);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.btnconsu);
            this.Controls.Add(this.txtcodi);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lblcodi);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.dgvPrestacion);
            this.Name = "frmPrestacion";
            this.Load += new System.EventHandler(this.frmPrestacion_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgv_prestacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvPrestacion;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblcodi;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtcodi;
        private System.Windows.Forms.Button btnconsu;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.CheckBox chktodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_prestacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod_prestacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descripcion;
    }
}