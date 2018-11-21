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
    public partial class frmRepoUsuariosXPerfil : Form
    {
        public frmRepoUsuariosXPerfil()
        {
            InitializeComponent();
        }

        private void frmRepoUsuariosXPerfil_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbPerfil, BDHelper.getBDHelper().ConsultaSQL("SELECT * FROM Perfiles"), "n_perfil", "id_perfil");
            //this.reportViewer1.RefreshReport();
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
            consulta = "SELECT Perfiles.n_perfil, Usuarios.nombreUsuario, Usuarios.email, Usuarios.telefono FROM Perfiles INNER JOIN Usuarios ON Perfiles.id_perfil = Usuarios.id_perfil WHERE Usuarios.id_perfil ='" + cmbPerfil.SelectedValue + "';";
            this.DataTable1BindingSource.DataSource = BDHelper.getBDHelper().ConsultaSQL(consulta);
            this.reportViewer1.RefreshReport();
        }

        private void frmRepoUsuariosXPerfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?",
               "Salir de Informe de usuario por perfil",
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
