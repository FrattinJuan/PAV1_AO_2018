using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_AO_2018.DataLayer;
using PAV1_AO_2018.GUILayer;


namespace PAV1_AO_2018.GUILayer.Reportes
{
    public partial class frmRepPacientesXOdontologo : Form
    {
        public frmRepPacientesXOdontologo()
        {
            InitializeComponent();
        }

        private void ReporteHistorial_Load(object sender, EventArgs e)

        {
            llenarCombo(cmbOdontologos, BDHelper.getBDHelper().ConsultaSQL("SELECT * From Usuarios"), "nombreUsuario", "id_usuario");
            
           // this.reportViewer1.RefreshReport();

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
           // MessageBox.Show(seleccionado);
            consulta = "select distinct P.nombre AS paciente, P.nroDocumento AS documento from Pacientes P, Usuarios O, HistorialesMedicos H where H.id_Usuario = "+seleccionado+" AND P.id_paciente = H.id_paciente ";
            this.pacientesXodontologosBindingSource.DataSource= BDHelper.getBDHelper().ConsultaSQL(consulta);
            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRepPacientesXOdontologo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?",
               "Salir de Informe de Paciente por Odontologo",
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
