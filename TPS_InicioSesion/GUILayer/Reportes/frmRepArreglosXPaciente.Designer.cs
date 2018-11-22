namespace PAV1_AO_2018.GUILayer.Reportes
{
    partial class frmRepArreglosXPaciente
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new PAV1_AO_2018.GUILayer.Reportes.DSArreglosXPaciente();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pAV1_AO_2018DataSet = new PAV1_AO_2018.PAV1_AO_2018DataSet();
            this.pAV1AO2018DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAV1AO2018DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV1_AO_2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV1AO2018DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV1AO2018DataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(396, 246);
            this.reportViewer2.TabIndex = 0;
            // 
            // reportViewer3
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "PAV1_AO_2018.GUILayer.Reportes.repArreglosXPaciente.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(1, 41);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1223, 589);
            this.reportViewer3.TabIndex = 0;
            // 
            // pAV1_AO_2018DataSet
            // 
            this.pAV1_AO_2018DataSet.DataSetName = "PAV1_AO_2018DataSet";
            this.pAV1_AO_2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAV1AO2018DataSetBindingSource
            // 
            this.pAV1AO2018DataSetBindingSource.DataSource = this.pAV1_AO_2018DataSet;
            this.pAV1AO2018DataSetBindingSource.Position = 0;
            // 
            // pAV1AO2018DataSetBindingSource1
            // 
            this.pAV1AO2018DataSetBindingSource1.DataSource = this.pAV1_AO_2018DataSet;
            this.pAV1AO2018DataSetBindingSource1.Position = 0;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(236, 8);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(83, 10);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(138, 20);
            this.txtDocumento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Documento:";
            // 
            // frmRepArreglosXPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1236, 642);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.reportViewer3);
            this.Name = "frmRepArreglosXPaciente";
            this.Text = "Reporte prestaciones por cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRepArreglosXPaciente_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV1_AO_2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV1AO2018DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV1AO2018DataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private PAV1_AO_2018DataSet pAV1_AO_2018DataSet;
        private System.Windows.Forms.BindingSource pAV1AO2018DataSetBindingSource;
        private System.Windows.Forms.BindingSource pAV1AO2018DataSetBindingSource1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private Reportes.DSArreglosXPaciente DataSet1;
        private DSArreglosXPaciente.DataTable1DataTable DataTable1TableAdapter;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
    }
}