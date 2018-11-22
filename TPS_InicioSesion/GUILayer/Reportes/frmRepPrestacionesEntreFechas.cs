using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_AO_2018.GUILayer.Reportes
{
    public partial class frmRepPrestacionesEntreFechas : Form
    {
        public frmRepPrestacionesEntreFechas()
        {
            InitializeComponent();
        }

        private void frmRepPrestacionesEntreFechas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSPrestacionesEntreFechas.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DSPrestacionesEntreFechas.DataTable1);

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string consulta;
            consulta = "SELECT HistorialesMedicos.fechaInicio AS Fecha, Pacientes.nombre AS Nombre, Pacientes.apellido AS Apellido, Prestaciones.cod_prestacion, Prestaciones.nombre AS Prestacion, Usuarios.nombreUsuario AS Odontologo FROM HistorialesMedicos INNER JOIN Pacientes ON HistorialesMedicos.id_paciente = Pacientes.id_paciente INNER JOIN Usuarios ON HistorialesMedicos.id_usuario = Usuarios.id_usuario CROSS JOIN  Prestaciones WHERE HistorialesMedicos.fechaInicio BETWEEN '" + dtpDesde.Text +"' AND '"+dtpHasta.Text+"';";
            this.DataTable1BindingSource.DataSource = BDHelper.getBDHelper().ConsultaSQL(consulta);
            this.reportViewer1.RefreshReport();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        }

        private void frmRepPrestacionesEntreFechas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?",
               "Salir de Informe de Prestaciones",
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
