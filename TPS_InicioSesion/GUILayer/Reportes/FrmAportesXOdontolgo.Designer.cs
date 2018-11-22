namespace PAV1_AO_2018.GUILayer.Reportes
{
    partial class FrmAportesXOdontolgo
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.aportXodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetAportesXOdontologo = new PAV1_AO_2018.GUILayer.Reportes.DataSetAportesXOdontologo();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.aportXodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAportesXOdontologo)).BeginInit();
            this.SuspendLayout();
            // 
            // aportXodoBindingSource
            // 
            this.aportXodoBindingSource.DataMember = "aportXodo";
            this.aportXodoBindingSource.DataSource = this.DataSetAportesXOdontologo;
            // 
            // DataSetAportesXOdontologo
            // 
            this.DataSetAportesXOdontologo.DataSetName = "DataSetAportesXOdontologo";
            this.DataSetAportesXOdontologo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(43, 9);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 1;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(177, 6);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.aportXodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PAV1_AO_2018.GUILayer.Reportes.RepoAportesXOdontologo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 35);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1057, 476);
            this.reportViewer1.TabIndex = 3;
            // 
            // FrmAportesXOdontolgo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1081, 609);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label1);
            this.Name = "FrmAportesXOdontolgo";
            this.Text = "Reportes Aportes por Odontolgo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAportesXOdontolgo_FormClosing);
            this.Load += new System.EventHandler(this.FrmAportesXOdontolgo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aportXodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAportesXOdontologo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Button btnImprimir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource aportXodoBindingSource;
        private DataSetAportesXOdontologo DataSetAportesXOdontologo;
    }
}