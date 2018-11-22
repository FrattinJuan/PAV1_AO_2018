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
    public partial class FrmPrestacionesporOdontologo : Form
    {
        public FrmPrestacionesporOdontologo()
        {
            InitializeComponent();
        }

        private void FrmPrestacionesporOdontologo_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbOdontologos, BDHelper.getBDHelper().ConsultaSQL("SELECT * From Usuarios"), "nombreUsuario", "id_usuario");
        }
        private void llenarCombo(ComboBox cmb, Object source, string display, String value)
        {
            cmb.DataSource = source;
            cmb.DisplayMember = display;
            cmb.ValueMember = value;
            cmb.SelectedIndex = -1;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string consulta;
            string seleccionado = cmbOdontologos.SelectedValue.ToString();
            consulta="select P.nombre AS prestacion , count(P.id_prestacion) AS cantidad"+
                "     from Prestaciones P, Usuarios U , DetalleHistorial D , HistorialesMedicos H"+
                "     where P.id_prestacion=D.id_prestacion and D.id_historial = H.id_historial and H.id_usuario = "+seleccionado+"  group by P.nombre";

            this.prestacionXodontolgoBindingSource.DataSource = BDHelper.getBDHelper().ConsultaSQL(consulta);
             this.reportViewer1.RefreshReport();
        }

        private void FrmPrestacionesporOdontologo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?",
               "Salir de Informe de prestaciones por Odontologo",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1)
               == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
