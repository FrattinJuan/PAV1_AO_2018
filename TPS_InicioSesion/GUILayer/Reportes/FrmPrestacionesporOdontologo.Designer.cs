namespace PAV1_AO_2018.GUILayer.Reportes
{
    partial class FrmPrestacionesporOdontologo
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
            this.prestacionXodontolgoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrestacionPorOdontologo = new PAV1_AO_2018.GUILayer.Reportes.DataSetPrestacionPorOdontologo();
            this.cmbOdontologos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionXodontolgoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrestacionPorOdontologo)).BeginInit();
            this.SuspendLayout();
            // 
            // prestacionXodontolgoBindingSource
            // 
            this.prestacionXodontolgoBindingSource.DataMember = "prestacionXodontolgo";
            this.prestacionXodontolgoBindingSource.DataSource = this.DataSetPrestacionPorOdontologo;
            // 
            // DataSetPrestacionPorOdontologo
            // 
            this.DataSetPrestacionPorOdontologo.DataSetName = "DataSetPrestacionPorOdontologo";
            this.DataSetPrestacionPorOdontologo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbOdontologos
            // 
            this.cmbOdontologos.FormattingEnabled = true;
            this.cmbOdontologos.Location = new System.Drawing.Point(94, 6);
            this.cmbOdontologos.Name = "cmbOdontologos";
            this.cmbOdontologos.Size = new System.Drawing.Size(121, 21);
            this.cmbOdontologos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odontologo";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSetPrestacionesporOdontolgos";
            reportDataSource2.Value = this.prestacionXodontolgoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PAV1_AO_2018.GUILayer.Reportes.RepoPrestacionesporOdontologos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1193, 564);
            this.reportViewer1.TabIndex = 2;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(280, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmPrestacionesporOdontologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1220, 609);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOdontologos);
            this.Name = "FrmPrestacionesporOdontologo";
            this.Text = "Reporte Prestaciones por Odontologo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrestacionesporOdontologo_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrestacionesporOdontologo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestacionXodontolgoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrestacionPorOdontologo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOdontologos;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.BindingSource prestacionXodontolgoBindingSource;
        private DataSetPrestacionPorOdontologo DataSetPrestacionPorOdontologo;
    }
}