using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_AO_2018.BusinessLayer;

namespace PAV1_AO_2018.GUILayer
{
    public partial class frmElemento : Form
    {
        private string elemento = string.Empty;
        public frmElemento(string id)
        {
            InitializeComponent();
            //Elemento = element1;
            elemento = id;
            this.Text = "Elemento" + id;
        }

        private void frmElemento_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbCara,BDHelper.getBDHelper().ConsultaSQL("SELECT * From Caras"),"nombre","id_cara");
            llenarCombo(cmbPrestacion, BDHelper.getBDHelper().ConsultaSQL("SELECT * From Prestaciones"), "nombre", "id_prestacion");
            txtNroElemento.Text = elemento;
            txtNroElemento.Enabled = false;
        }
        private void llenarCombo(ComboBox cmb, Object source, string display, String value)
        {
            cmb.DataSource = source;
            cmb.DisplayMember = display;
            cmb.ValueMember = value;
            cmb.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmHistorialMedico historial = new frmHistorialMedico();
            //historial.txtNroHistorial.Text = txtPrecio.Text;
            historial.dgvDetalle.Rows.Add(txtNroElemento.Text, cmbCara.SelectedValue, cmbPrestacion.SelectedValue, txtPrecio.Text);
            this.Close();
           
        }
    }
}
