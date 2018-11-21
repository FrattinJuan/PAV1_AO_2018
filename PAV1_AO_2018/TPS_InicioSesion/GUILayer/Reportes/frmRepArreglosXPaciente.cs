using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_AO_2018.GUILayer;

namespace PAV1_AO_2018.GUILayer.Reportes
{
    public partial class frmRepArreglosXPaciente : Form
    {
        public frmRepArreglosXPaciente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            //this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);

            //this.reportViewer3.RefreshReport();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string consulta;
            consulta = "SELECT Pacientes.nroDocumento, Prestaciones.cod_prestacion, Prestaciones.nombre AS 'Prestacion', Prestaciones.descripcion, DetalleHistorial.importe FROM DetalleHistorial INNER JOIN HistorialesMedicos ON DetalleHistorial.id_historial = HistorialesMedicos.id_historial INNER JOIN Pacientes ON HistorialesMedicos.id_paciente = Pacientes.id_paciente INNER JOIN Prestaciones ON DetalleHistorial.id_prestacion = Prestaciones.id_prestacion WHERE Pacientes.nrodocumento = '"+txtDocumento.Text+"';";
            this.DataTable1BindingSource.DataSource = BDHelper.getBDHelper().ConsultaSQL(consulta);
            this.reportViewer3.RefreshReport();
        }

        private void frmRepArreglosXPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?",
               "Salir de Informe de Areglos por Paciente",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1)
               == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        
        

    }
}
