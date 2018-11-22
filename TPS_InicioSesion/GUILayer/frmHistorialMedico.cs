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
            groupBoxElemento.Enabled = false;
            txtOdontograma.Enabled = false;
            btnQuitar.Enabled = false;
            btnGrabar.Enabled = false;
            
        }
        private void frmHistorialMedico_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbCara, BDHelper.getBDHelper().ConsultaSQL("SELECT * From Caras"), "nombre", "id_cara");
            llenarCombo(cmbPrestacion, BDHelper.getBDHelper().ConsultaSQL("SELECT * From Prestaciones"), "nombre", "id_prestacion");
            DataTable tabla = new DataTable();
            tabla = BDHelper.getBDHelper().ConsultaSQL("Select Ident_current('HistorialesMedicos')");
            
        }
        private void btnCargarPaciente_Click(object sender, EventArgs e)
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
                        DataTable historial = new DataTable();
                        historial = BDHelper.getBDHelper().ConsultaSQL("Select A.fechaInicio,A.id_Historial,B.id_prestacion,B.id_elemento,B.id_cara,B.descripcion,B.importe FROM HistorialesMedicos A, DetalleHistorial B WHERE A.id_historial = B.id_historial AND id_paciente = " + txtIdPaciente.Text);
                        for (int i = 0; i < historial.Rows.Count; i++)
                            dgvHistorial.Rows.Add(historial.Rows[i][0].ToString(), historial.Rows[i][1].ToString(), historial.Rows[i][2].ToString(), historial.Rows[i][3].ToString(), historial.Rows[i][4].ToString(), historial.Rows[i][5], historial.Rows[i][6].ToString());
                    }
                     
                    else
                        MessageBox.Show("Paciente no encontrado");
                }
                else
                    MessageBox.Show("Debe ingresar un numero de Paciente...");
            }
        }

        private void btnCargarOdontologo_Click(object sender, EventArgs e)
        {
            if (txtIdOdontologo.Text == "")
                MessageBox.Show("Debe ingresar un Odontologo");

            else
            {
                int numero;
                if (Int32.TryParse(txtIdOdontologo.Text, out numero))
                {
                    DataTable tabla = new DataTable();
                    tabla = BDHelper.getBDHelper().ConsultaSQL("select nombreUsuario from usuarios where id_perfil = 2 AND estado = 'S' AND id_usuario = " + txtIdOdontologo.Text);
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
            btnQuitar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGrabar.Enabled = true;
            dgvDetalle.Rows.Add(txtNroElemento.Text, cmbPrestacion.SelectedValue, cmbCara.SelectedValue, txtPrecio.Text, txtDescripcion.Text);
            txtNroElemento.Clear();
            txtPrecio.Clear();
            cmbCara.ResetText();
            cmbPrestacion.ResetText();
            groupBoxElemento.Enabled = false;

        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count > 0)
            {
                dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
                calcularTotal();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count > 0)
            {
                grabarHistorial();
            }
            else
                MessageBox.Show("Debe tener al menos una carga");
        }

        private void grabarHistorial()
        {
            BDHelper.getBDHelper().conectarConTransaccion();
            grabarPedido();
            grabarDetalle();
            BDHelper.getBDHelper().desconectar();

        }

        private void grabarPedido()
        {
            string consulta = "insert into HistorialesMedicos(id_paciente,id_usuario,fechaInicio,importeTotal) values(" 
                                                              + txtIdPaciente.Text + ","
                                                              + txtIdOdontologo.Text + ",'"
                                                              + dtpfechaHistorial.Text + "',"
                                                              + txtTotal.Text.Replace(",", ".") + ")";

            BDHelper.getBDHelper().EjecutarSQLConTransaccion(consulta);
        }
        private void grabarDetalle()
        {
            DataTable numPedido = new DataTable();
            numPedido = BDHelper.getBDHelper().ConsultaSQL("Select Ident_current('HistorialesMedicos')");
           // MessageBox.Show(numPedido.Rows[0][0].ToString());
            for (int i = 0; i < dgvDetalle.Rows.Count; i++)
            {
                string consulta = "Insert INTO DetalleHistorial(id_historial,id_prestacion,id_elemento,id_cara,descripcion,importe) values("
                                                                       + numPedido.Rows[0][0] + ","
                                                                       + dgvDetalle.Rows[i].Cells["col_id_prestacion"].Value.ToString() + ","
                                                                       + dgvDetalle.Rows[i].Cells["col_id_elemento"].Value.ToString() + ","
                                                                       + dgvDetalle.Rows[i].Cells["col_id_cara"].Value.ToString() + ",'"
                                                                       + dgvDetalle.Rows[i].Cells["col_descripcion"].Value.ToString() + "',"
                                                                       + dgvDetalle.Rows[i].Cells["col_importe"].Value.ToString().Replace(",", ".") + ")";
                BDHelper.getBDHelper().EjecutarSQLConTransaccion(consulta);
            }
        }
        private void llenarCombo(ComboBox cmb, Object source, string display, String value)
        {
            cmb.DataSource = source;
            cmb.DisplayMember = display;
            cmb.ValueMember = value;
            cmb.SelectedIndex = -1;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            this.btn11.BackColor = Color.FromArgb(120, 0, 0);
            int nro = 11;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int nro = 25;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn42_Click(object sender, EventArgs e)
        {
            int nro = 42;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn71_Click(object sender, EventArgs e)
        {
            int nro = 71;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            int nro = 12;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            int nro = 13;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            int nro = 14;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            int nro = 15;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            int nro = 16;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            int nro = 17;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            int nro = 18;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            int nro = 21;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            int nro = 22;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            int nro = 23;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();    
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            int nro = 24;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            int nro = 26;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            int nro = 27;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            int nro = 28;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        
        private void txtNroHistorial_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        private void txtNombrePaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn41_Click(object sender, EventArgs e)
        {
            int nro = 41;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn43_Click(object sender, EventArgs e)
        {
            int nro = 43;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn44_Click(object sender, EventArgs e)
        {
            int nro = 44;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            int nro = 45;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn46_Click(object sender, EventArgs e)
        {
            int nro = 46;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn47_Click(object sender, EventArgs e)
        {
            int nro = 47;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn48_Click(object sender, EventArgs e)
        {
            int nro = 48;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            int nro = 31;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            int nro = 32;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            int nro = 33;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            int nro = 34;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            int nro = 35;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            int nro = 36;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn37_Click(object sender, EventArgs e)
        {
            int nro = 37;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn38_Click(object sender, EventArgs e)
        {
            int nro = 38;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn51_Click(object sender, EventArgs e)
        {
            int nro = 51;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn52_Click(object sender, EventArgs e)
        {
            int nro = 52;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn53_Click(object sender, EventArgs e)
        {
            int nro = 53;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn54_Click(object sender, EventArgs e)
        {
            int nro = 54;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn55_Click(object sender, EventArgs e)
        {
            int nro = 55;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn61_Click(object sender, EventArgs e)
        {
            int nro = 61;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn62_Click(object sender, EventArgs e)
        {
            int nro = 62;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn63_Click(object sender, EventArgs e)
        {
            int nro = 63;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn64_Click(object sender, EventArgs e)
        {
            int nro = 64;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn65_Click(object sender, EventArgs e)
        {
            int nro = 65;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn72_Click(object sender, EventArgs e)
        {
            int nro = 72;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn73_Click(object sender, EventArgs e)
        {
            int nro = 73;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn74_Click(object sender, EventArgs e)
        {
            int nro = 74;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn75_Click(object sender, EventArgs e)
        {
            int nro = 75;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn81_Click(object sender, EventArgs e)
        {
            int nro = 81;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn82_Click(object sender, EventArgs e)
        {
            int nro = 81;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn83_Click(object sender, EventArgs e)
        {
            int nro = 83;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn84_Click(object sender, EventArgs e)
        {
            int nro = 84;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        private void btn85_Click(object sender, EventArgs e)
        {
            int nro = 85;
            groupBoxElemento.Enabled = true;
            txtNroElemento.Text = nro.ToString();
            txtNroElemento.Enabled = false;
            cmbCara.Focus();
        }

        

        
       
        

        

    //        string consulta = "SELECT * FROM Pacientes WHERE id_paciente = " + idPaciente;
    //        DataTable pacientes = new DataTable();
    //        pacientes = BDHelper.getBDHelper().ConsultaSQL(consulta);
    //        txtNombrePaciente.Text = pacientes.Rows[0].ItemArray[1].ToString();
    //        txtApellidoPaciente.Text = usuario.Rows[0].ItemArray[2].ToString();
    }
}
