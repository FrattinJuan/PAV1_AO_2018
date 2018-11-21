namespace PAV1_AO_2018.GUILayer
{
    partial class frmElemento
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
            this.lblElemento = new System.Windows.Forms.Label();
            this.txtNroElemento = new System.Windows.Forms.TextBox();
            this.lblcara = new System.Windows.Forms.Label();
            this.cmbCara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPrestacion = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElemento.Location = new System.Drawing.Point(4, 31);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(153, 21);
            this.lblElemento.TabIndex = 4;
            this.lblElemento.Text = "Pieza dental Nro";
            // 
            // txtNroElemento
            // 
            this.txtNroElemento.Location = new System.Drawing.Point(183, 29);
            this.txtNroElemento.Name = "txtNroElemento";
            this.txtNroElemento.Size = new System.Drawing.Size(127, 26);
            this.txtNroElemento.TabIndex = 5;
            // 
            // lblcara
            // 
            this.lblcara.AutoSize = true;
            this.lblcara.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcara.Location = new System.Drawing.Point(53, 73);
            this.lblcara.Name = "lblcara";
            this.lblcara.Size = new System.Drawing.Size(54, 21);
            this.lblcara.TabIndex = 7;
            this.lblcara.Text = "Cara";
            // 
            // cmbCara
            // 
            this.cmbCara.FormattingEnabled = true;
            this.cmbCara.Location = new System.Drawing.Point(183, 70);
            this.cmbCara.Name = "cmbCara";
            this.cmbCara.Size = new System.Drawing.Size(127, 28);
            this.cmbCara.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Prestacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Precio";
            // 
            // cmbPrestacion
            // 
            this.cmbPrestacion.FormattingEnabled = true;
            this.cmbPrestacion.Location = new System.Drawing.Point(183, 113);
            this.cmbPrestacion.Name = "cmbPrestacion";
            this.cmbPrestacion.Size = new System.Drawing.Size(127, 28);
            this.cmbPrestacion.TabIndex = 11;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(183, 156);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(127, 26);
            this.txtPrecio.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(31, 199);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 41);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(199, 197);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 41);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(345, 267);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cmbPrestacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCara);
            this.Controls.Add(this.lblcara);
            this.Controls.Add(this.txtNroElemento);
            this.Controls.Add(this.lblElemento);
            this.Name = "frmElemento";
            this.Text = "Elemento";
            this.Load += new System.EventHandler(this.frmElemento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.TextBox txtNroElemento;
        private System.Windows.Forms.Label lblcara;
        private System.Windows.Forms.ComboBox cmbCara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPrestacion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

    }
}