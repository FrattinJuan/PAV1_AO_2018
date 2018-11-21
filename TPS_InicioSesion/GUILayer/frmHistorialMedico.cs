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
    public partial class frmHistorialMedico : Form
    {
        public frmHistorialMedico()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtIdPaciente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdPaciente.Text == "")
                MessageBox.Show("Debe ingresar un Paciente");

            else
            {
                int numero;
                if (Int32.TryParse(txtIdPaciente.Text, out numero))
                {
                    DataTable tabla = new DataTable();
                    tabla = BDHelper.getBDHelper().ConsultaSQL("select nombre, apellido, id_odontograma from Pacientes where id_paciente = " + txtIdPaciente.Text);
                    if (tabla.Rows.Count > 0)
                    {
                        txtNombrePaciente.Text = tabla.Rows[0][0].ToString();
                        txtApellidoPaciente.Text = tabla.Rows[0][1].ToString();
                        txtOdontograma.Text = tabla.Rows[0][2].ToString();
                    }
                    else
                        MessageBox.Show("Paciente no encontrado");
                }
                else
                    MessageBox.Show("Debe ingresar un numero de Paciente...");
            }
        }

        private void txtIdOdontologo_TextChanged(object sender, EventArgs e)
        {
            if (txtIdOdontologo.Text == "")
                MessageBox.Show("Debe ingresar un Odontologo");

            else
            {
                int numero;
                if (Int32.TryParse(txtIdOdontologo.Text, out numero))
                {
                    DataTable tabla = new DataTable();
                    tabla = BDHelper.getBDHelper().ConsultaSQL("select nombreUsuario from usuarios where id_perfil = 2 AND id_usuario = " + txtIdOdontologo.Text);
                    if (tabla.Rows.Count > 0)
                    {
                        txtOdontologo.Text = tabla.Rows[0][0].ToString();
                        
                    }
                    else
                        MessageBox.Show("Odontologo no encontrado");
                }
                else
                    MessageBox.Show("Debe ingresar un numero de Odontologo...");
            }
        }

        private void btnBuscarPacientes_Click(object sender, EventArgs e)
        {
            new frmBuscarPacientes().ShowDialog();
        }

        private void btnBuscarOdontologos_Click(object sender, EventArgs e)
        {
            new BuscarOdontologos().ShowDialog();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            this.btn11.BackColor = Color.FromArgb(120, 0, 0);
            new GUILayer.frmElemento("11").Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("25").Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void btn71_Click(object sender, EventArgs e)
        {

        }

        private void btn12_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("12").Show();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("13").Show();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("14").Show();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("15").Show();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("16").Show();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("17").Show();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("18").Show();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("21").Show();
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("22").Show();
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("23").Show();
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("24").Show();
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("26").Show();
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("27").Show();
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            new GUILayer.frmElemento("28").Show();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count > 0)
            {
                grabarPedido();
                grabarDetalle();
            }
            else
                MessageBox.Show("Debe tener al menos una carga");
        }

        private void grabarPedido()
        {
            string consulta = "insert into HistorialesMedicos values(" + txtIdPaciente.Text + ","
                                                              + txtIdOdontologo.Text + ",'"
                                                              + dtpFecha.Value.ToShortDateString() + "',"
                                                              + txtTotal.Text.Replace(",", ".") + ")";
                                                              
            BDHelper.getBDHelper().EjecutarSQL(consulta);
        }
        private void grabarDetalle()
        {
            for (int i = 0; i < dgvDetalle.Rows.Count; i++)
            {
                string consulta = "Insert INTO DetalleHistorial values("
                                                                       + txtNroHistorial.Text + ","
                                                                       + dgvDetalle.Rows[i].Cells["col_id_prestacion"].Value.ToString() + ","
                                                                       + dgvDetalle.Rows[i].Cells["col_id_elemento"].Value.ToString() + ","
                                                                       + dgvDetalle.Rows[i].Cells["col_id_cara"].Value.ToString() + ",NULL,"
                                                                       + dgvDetalle.Rows[i].Cells["col_importe"].Value.ToString().Replace(",", ".") + ")";
                BDHelper.getBDHelper().EjecutarSQL(consulta);
            }
        }

        private void txtNroHistorial_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frmHistorialMedico_Load(object sender, EventArgs e)
        {
            //DataTable tabla = new DataTable();
            //tabla = BDHelper.getBDHelper().ConsultaSQL("SELECT id_historial = SCOPE_IDENTITY()");
            //txtNroHistorial.Text = tabla.Rows[0][0].ToString();
            //"select @@identity AS 'id_historial'
        }

        private void txtNombrePaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private double calcularTotal()
        {
            double total = 0;
            for (int i = 0; i < dgvDetalle.Rows.Count; i++)
                total += Convert.ToDouble(dgvDetalle.Rows[i].Cells[3].Value);

            return total;
        }

        private void dgvDetalle_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtTotal.Text = calcularTotal().ToString();
        }

    //        string consulta = "SELECT * FROM Pacientes WHERE id_paciente = " + idPaciente;
    //        DataTable pacientes = new DataTable();
    //        pacientes = BDHelper.getBDHelper().ConsultaSQL(consulta);
    //        txtNombrePaciente.Text = pacientes.Rows[0].ItemArray[1].ToString();
    //        txtApellidoPaciente.Text = usuario.Rows[0].ItemArray[2].ToString();
    }
}
