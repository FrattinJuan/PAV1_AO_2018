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
    public partial class FrmRepCantidadPrestaciones : Form
    {
        public FrmRepCantidadPrestaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consulta;
            if (dtpFechaDesde.Value.ToLongDateString() != string.Empty && dtpFechaHasta.Value.ToLongDateString() != string.Empty)
            {
                consulta = "select P.nombre AS prestacion, COUNT(P.id_prestacion) AS cantidad " +
                    "     from Prestaciones P , HistorialesMedicos H , DetalleHistorial D" +
                    "      where P.id_prestacion=D.id_prestacion AND D.id_historial=H.id_historial" +
                    "      AND H.fechainicio BETWEEN '" + dtpFechaDesde.Value.ToString() + "' AND '" + dtpFechaHasta.Value.ToString() +
                    "' GROUP BY P.nombre";
                this.pestacionesRealizadasBindingSource.DataSource = BDHelper.getBDHelper().ConsultaSQL(consulta);
                this.reportViewer1.RefreshReport();
            }
        }

        private void FrmRepCantidadPrestaciones_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmRepCantidadPrestaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?",
               "Salir de Informe de cantidad de prestaciones",
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
