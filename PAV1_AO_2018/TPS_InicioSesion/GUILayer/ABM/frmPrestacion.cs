using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using PAV1_AO_2018.BusinessLayer;
using PAV1_AO_2018.BusinessLayer.Services;

namespace PAV1_AO_2018.GUILayer
{
    public partial class frmPrestacion : Form
    {
        private PrestacionService oPrestacionService;
       
        public frmPrestacion()
        {
            InitializeComponent();
            oPrestacionService = new PrestacionService();
            bteditar.Enabled = false;
            bteliminar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GUILayer.frmABMPrestaciones formulario = new GUILayer.frmABMPrestaciones();
            formulario.ShowDialog();
        }

       
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void frmPrestacion_Load_1(object sender, EventArgs e)
        {
        
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            frmABMPrestaciones formulario = new frmABMPrestaciones();
            formulario.seleccionar_prestacion(frmABMPrestaciones.Opcion.update, map_prestacion_fila());
            formulario.ShowDialog();
            btnconsu_Click(sender, e);
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            frmABMPrestaciones formulario = new frmABMPrestaciones();
            formulario.seleccionar_prestacion(frmABMPrestaciones.Opcion.delete, map_prestacion_fila());
            formulario.ShowDialog();
            btnconsu_Click(sender, e);
        }

        
        private Prestacion map_prestacion_fila()
        {
            Prestacion oPrestacion = new Prestacion();
            oPrestacion.id_prestacion = int.Parse(dgvPrestacion.CurrentRow.Cells["col_id_prestacion"].Value.ToString());
            oPrestacion.cod_prestacion = dgvPrestacion.CurrentRow.Cells["col_cod_prestacion"].Value.ToString();
            oPrestacion.nombre = dgvPrestacion.CurrentRow.Cells["col_nombre"].Value.ToString();
            oPrestacion.descripcion = dgvPrestacion.CurrentRow.Cells["col_descripcion"].Value.ToString();
            return oPrestacion;
        }

        private void btnconsu_Click(object sender, EventArgs e)
        {
            List<object> filters = new List<object>();
            bool flag_filtros = false;

            if (!chktodos.Checked)
            {

                if (txtnom.Text != string.Empty)
                {
                    // Si el cmb tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                    filters.Add(txtnom.Text);
                    flag_filtros = true;
                    bteditar.Enabled = true;
                    bteliminar.Enabled = true;
                }
                else
                    filters.Add(null);


                if (txtcodi.Text != string.Empty)
                {
                    // Si el cmb tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                    filters.Add(txtcodi.Text);
                    flag_filtros = true;
                    bteditar.Enabled = true;
                    bteliminar.Enabled = true;
                }
                else
                    filters.Add(null);

                if (flag_filtros)
                    llenarGrilla(oPrestacionService.consultarPrestacionesConFiltros(filters));
                else
                    MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                llenarGrilla(oPrestacionService.consultarPrestaciones());
                bteditar.Enabled = true;
                bteliminar.Enabled = true;
        }

        private void llenarGrilla(IList<Prestacion> source)
        {
            dgvPrestacion.Rows.Clear();
            foreach (Prestacion oPrestacion in source)
                dgvPrestacion.Rows.Add(new string[] { oPrestacion.id_prestacion.ToString(), oPrestacion.nombre, oPrestacion.cod_prestacion, oPrestacion.descripcion});
        }

        private void chktodos_CheckedChanged(object sender, EventArgs e)
        {

            {
                if (chktodos.Checked)
                {
                    txtnom.Enabled = false;
                    txtcodi.Enabled = false;
                }
                else
                {
                    txtnom.Enabled = true;
                    txtcodi.Enabled = true;
                }
            }
        }

    }
}
