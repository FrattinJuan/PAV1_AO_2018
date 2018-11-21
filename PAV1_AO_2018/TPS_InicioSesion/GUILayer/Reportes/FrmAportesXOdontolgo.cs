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
    public partial class FrmAportesXOdontolgo : Form
    {
        public FrmAportesXOdontolgo()
        {
            InitializeComponent();
        }

        private void FrmAportesXOdontolgo_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
             if (txtAño.Text != string.Empty)
            {
                string consulta;
                consulta = " SELECT U.nombreUsuario AS Odontologo, COUNT(H.id_historial) AS Aporte" +
                          "     FROM Usuarios U, HistorialesMedicos H" +
                          "     WHERE  U.id_usuario= H.id_usuario AND YEAR(H.fechaInicio)= '" + txtAño.Text +
                          "'    GROUP BY U.nombreUsuario";

                this.aportXodoBindingSource.DataSource=BDHelper.getBDHelper().ConsultaSQL(consulta);
                 this.reportViewer1.RefreshReport();
            }
            else
                MessageBox.Show("Debe Ingresar el año", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmAportesXOdontolgo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?",
               "Salir de Informe de Aportes por Odontologo",
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

