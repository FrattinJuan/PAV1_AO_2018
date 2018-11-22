namespace PAV1_AO_2018.GUILayer
{
    partial class frmReportes
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRepHistoriasCliXFecha = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnPrestacionesPorOdontologo = new System.Windows.Forms.Button();
            this.btnAportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pacientes por odontologo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(21, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Arreglos por paciente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRepHistoriasCliXFecha
            // 
            this.btnRepHistoriasCliXFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepHistoriasCliXFecha.Location = new System.Drawing.Point(21, 116);
            this.btnRepHistoriasCliXFecha.Name = "btnRepHistoriasCliXFecha";
            this.btnRepHistoriasCliXFecha.Size = new System.Drawing.Size(193, 36);
            this.btnRepHistoriasCliXFecha.TabIndex = 2;
            this.btnRepHistoriasCliXFecha.Text = "Prestaciones entre fechas";
            this.btnRepHistoriasCliXFecha.UseVisualStyleBackColor = true;
            this.btnRepHistoriasCliXFecha.Click += new System.EventHandler(this.btnRepHistoriasCliXFecha_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(21, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "Usuarios por perfil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(232, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "estadistico de prestaciones";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(232, 62);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(193, 36);
            this.btnIngreso.TabIndex = 3;
            this.btnIngreso.Text = "Estadistico Ingreso";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnPrestacionesPorOdontologo
            // 
            this.btnPrestacionesPorOdontologo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestacionesPorOdontologo.Location = new System.Drawing.Point(232, 107);
            this.btnPrestacionesPorOdontologo.Name = "btnPrestacionesPorOdontologo";
            this.btnPrestacionesPorOdontologo.Size = new System.Drawing.Size(193, 45);
            this.btnPrestacionesPorOdontologo.TabIndex = 7;
            this.btnPrestacionesPorOdontologo.Text = "Estadistico de prestaciones por odontologo";
            this.btnPrestacionesPorOdontologo.UseVisualStyleBackColor = true;
            this.btnPrestacionesPorOdontologo.Click += new System.EventHandler(this.btnPrestacionesPorOdontologo_Click);
            // 
            // btnAportes
            // 
            this.btnAportes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAportes.Location = new System.Drawing.Point(232, 158);
            this.btnAportes.Name = "btnAportes";
            this.btnAportes.Size = new System.Drawing.Size(193, 49);
            this.btnAportes.TabIndex = 6;
            this.btnAportes.Text = "Estadistico de Aportes por Odontologos";
            this.btnAportes.UseVisualStyleBackColor = true;
            this.btnAportes.Click += new System.EventHandler(this.btnAportes_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(456, 219);
            this.Controls.Add(this.btnPrestacionesPorOdontologo);
            this.Controls.Add(this.btnAportes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.btnRepHistoriasCliXFecha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmReportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRepHistoriasCliXFecha;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnPrestacionesPorOdontologo;
        private System.Windows.Forms.Button btnAportes;
    }
}