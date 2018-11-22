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
    public partial class FrmIngresoporPrestacion : Form
    {
        public FrmIngresoporPrestacion()
        {
            InitializeComponent();
        }

        private void FrmIngresoporPrestacion_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            string consulta;
            if (dtpFechaDesde.Value.ToLongDateString() != string.Empty && dtpFechaHasta.Value.ToLongDateString() != string.Empty)
            {
                consulta = "select P.nombre AS prestacion, SUM(H.importeTotal) AS cantidad" +
                         "  from Prestaciones P, HistorialesMedicos H , DetalleHistorial D" +
                           " WHERE P.id_prestacion = D.id_prestacion AND " +
                           " H.fechainicio BETWEEN  '" + dtpFechaDesde.Value.ToString() + "' AND '" + dtpFechaHasta.Value.ToString() +
                             "' GROUP BY P.nombre";

                this.pestacionesRealizadasBindingSource.DataSource = BDHelper.getBDHelper().ConsultaSQL(consulta);
                this.reportViewer1.RefreshReport();
            }
        }

        private void FrmIngresoporPrestacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?",
               "Salir de Informe de Ingreso por Prestaciones",
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