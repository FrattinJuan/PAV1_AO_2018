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
    public partial class BuscarOdontologos : Form
    {
        public BuscarOdontologos()
        {
            InitializeComponent();
        }

        private void BuscarOdontologos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = BDHelper.getBDHelper().ConsultaSQL("select id_usuario, nombreUsuario, nroMatricula from Usuarios where id_perfil = 2 AND estado = 'S'");
            for (int i = 0; i < tabla.Rows.Count ; i++)
            dgvOdontologos.Rows.Add(tabla.Rows[i][0].ToString(), tabla.Rows[i][1].ToString(), tabla.Rows[i][2].ToString());
        }
    }
}
