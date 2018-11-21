namespace PAV1_AO_2018.GUILayer.Reportes
{
    partial class frmRepPacientesXOdontologo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pacientesXodontologosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReporteOdontologoxCliente = new PAV1_AO_2018.GUILayer.Reportes.DataSetReporteOdontologoxCliente();
            this.pAV1AO2018DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAV1_AO_2018DataSet = new PAV1_AO_2018.PAV1_AO_2018DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbkodontologo = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cmbOdontologos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesXodontologosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteOdontologoxCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV1AO2018DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV1_AO_2018DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pacientesXodontologosBindingSource
            // 
            this.pacientesXodontologosBindingSource.DataMember = "pacientesXodontologos";
            this.pacientesXodontologosBindingSource.DataSource = this.DataSetReporteOdontologoxCliente;
            // 
            // DataSetReporteOdontologoxCliente
            // 
            this.DataSetReporteOdontologoxCliente.DataSetName = "DataSetReporteOdontologoxCliente";
            this.DataSetReporteOdontologoxCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAV1AO2018DataSetBindingSource
            // 
            this.pAV1AO2018DataSetBindingSource.DataSource = this.pAV1_AO_2018DataSet;
            this.pAV1AO2018DataSetBindingSource.Position = 0;
            // 
            // pAV1_AO_2018DataSet
            // 
            this.pAV1_AO_2018DataSet.DataSetName = "PAV1_AO_2018DataSet";
            this.pAV1_AO_2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.pacientesXodontologosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PAV1_AO_2018.GUILayer.Reportes.repPacientexOdontologo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 32);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1232, 543);
            this.reportViewer1.TabIndex = 0;
            // 
            // lbkodontologo
            // 
            this.lbkodontologo.AutoSize = true;
            this.lbkodontologo.Location = new System.Drawing.Point(12, 9);
            this.lbkodontologo.Name = "lbkodontologo";
            this.lbkodontologo.Size = new System.Drawing.Size(62, 13);
            this.lbkodontologo.TabIndex = 1;
            this.lbkodontologo.Text = "Odontologo";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(216, 6);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cmbOdontologos
            // 
            this.cmbOdontologos.FormattingEnabled = true;
            this.cmbOdontologos.Location = new System.Drawing.Point(80, 6);
            this.cmbOdontologos.Name = "cmbOdontologos";
            this.cmbOdontologos.Size = new System.Drawing.Size(121, 21);
            this.cmbOdontologos.TabIndex = 3;
            this.cmbOdontologos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmRepPacientesXOdontologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1235, 581);
            this.Controls.Add(this.cmbOdontologos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lbkodontologo);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRepPacientesXOdontologo";
            this.Text = "Reporte pacientes por odontologo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRepPacientesXOdontologo_FormClosing);
            this.Load += new System.EventHandler(this.ReporteHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesXodontologosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteOdontologoxCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV1AO2018DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV1_AO_2018DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pAV1AO2018DataSetBindingSource;
        private PAV1_AO_2018DataSet pAV1_AO_2018DataSet;
        private System.Windows.Forms.Label lbkodontologo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cmbOdontologos;
        private System.Windows.Forms.BindingSource pacientesXodontologosBindingSource;
        private DataSetReporteOdontologoxCliente DataSetReporteOdontologoxCliente;
    }
}