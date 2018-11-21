using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_AO_2018
{
    public partial class frmBuscarPacientes : Form
    {
        string idPaciente = string.Empty;
        public frmBuscarPacientes()
        {
            InitializeComponent();
        }

        private void frmBuscarPacientes_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = BDHelper.getBDHelper().ConsultaSQL("select id_paciente, nombre, apellido, nroDocumento from Pacientes");
            for (int i = 0; i < tabla.Rows.Count ; i++)
            dgvClientes.Rows.Add(tabla.Rows[i][0].ToString(), tabla.Rows[i][1].ToString(), tabla.Rows[i][2].ToString(), tabla.Rows[i][3].ToString());
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idPaciente = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(idPaciente);
        }
        
    }
}
