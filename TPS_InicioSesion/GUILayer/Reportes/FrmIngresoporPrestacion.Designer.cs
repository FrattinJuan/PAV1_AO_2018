namespace PAV1_AO_2018.GUILayer.Reportes
{
    partial class FrmIngresoporPrestacion
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
            this.pestacionesRealizadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrestacionesRealizadas = new PAV1_AO_2018.GUILayer.Reportes.DataSetPrestacionesRealizadas();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pestacionesRealizadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrestacionesRealizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // pestacionesRealizadasBindingSource
            // 
            this.pestacionesRealizadasBindingSource.DataMember = "pestacionesRealizadas";
            this.pestacionesRealizadasBindingSource.DataSource = this.DataSetPrestacionesRealizadas;
            // 
            // DataSetPrestacionesRealizadas
            // 
            this.DataSetPrestacionesRealizadas.DataSetName = "DataSetPrestacionesRealizadas";
            this.DataSetPrestacionesRealizadas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(84, 3);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(192, 20);
            this.dtpFechaDesde.TabIndex = 11;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(84, 35);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(192, 20);
            this.dtpFechaHasta.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "fecha Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "fecha desde";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(298, 35);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pestacionesRealizadasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PAV1_AO_2018.GUILayer.Reportes.RepoIngresoPrestacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1120, 496);
            this.reportViewer1.TabIndex = 12;
            // 
            // FrmIngresoporPrestacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1145, 583);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImprimir);
            this.Name = "FrmIngresoporPrestacion";
            this.Text = "Reporte Ingreso por Prestacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIngresoporPrestacion_FormClosing);
            this.Load += new System.EventHandler(this.FrmIngresoporPrestacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pestacionesRealizadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrestacionesRealizadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.BindingSource pestacionesRealizadasBindingSource;
        private DataSetPrestacionesRealizadas DataSetPrestacionesRealizadas;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}