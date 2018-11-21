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
using PAV1_AO_2018.BusinessLayer.Services;

namespace PAV1_AO_2018.GUILayer
{
    public partial class frmABMPrestaciones : Form
    {
        BDHelper helper = new BDHelper();
        public frmABMPrestaciones()
        {
            InitializeComponent();

        }

         public enum Opcion
         {
            insert,
            update,
            delete
         }

        private Opcion _action = Opcion.insert;
        private PrestacionService oPrestacionService = new PrestacionService();
        private Prestacion oPrestacionSelected;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmABMPrestaciones_Load(object sender, EventArgs e)
        {
            switch (_action)
                {
                case Opcion.insert:
                    {
                        this.Text = "Nuevo Prestacion";
                        break;
                    }
                    case Opcion.update:
                    {
                        this.Text = "Actualizar Prestacion";
                        // Recuperar usuario seleccionado en la grilla 
                        mostrar_datos();
                        txtNombre.Enabled = true;
                        txtCodigoPrestacion.Enabled = true;
                        txtDescripcion.Enabled = true;
            
                        break;
                    }
                     case Opcion.delete:
                    {
                        mostrar_datos();
                        this.Text = "Deshabilitar Prestacion";
                        txtNombre.Enabled = false;
                        txtCodigoPrestacion.Enabled = false;
                        txtDescripcion.Enabled = false;
                       
                        break;
                    }

                }
        }
        private void mostrar_datos()
        {
            if (oPrestacionSelected != null)
            {
              
                txtCodigoPrestacion.Text = oPrestacionSelected.cod_prestacion;
                txtNombre.Text = oPrestacionSelected.nombre;
                txtDescripcion.Text = oPrestacionSelected.descripcion;

            }
        }

        public void seleccionar_prestacion(Opcion op, Prestacion prestacionSelected)
            {
                _action = op;
                oPrestacionSelected = prestacionSelected;
            }

      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool existe_nombre()
        {
            return (oPrestacionService.validarcodigoPrestacion(txtCodigoPrestacion.Text) != null);
        }
        private bool validar_campos()
        {
            // campos obligatorios
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.Red;
                txtNombre.Focus();
                return false;
            }
            else
                txtNombre.BackColor = Color.White;

            if (txtCodigoPrestacion.Text == string.Empty)
            {
                txtCodigoPrestacion.BackColor = Color.Red;
                txtCodigoPrestacion.Focus();
                return false;
            }
            else
                txtCodigoPrestacion.BackColor = Color.White;

            return true;
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            string str_sql = "";
           Prestacion oPrestacion;

            switch (_action)
                {
                case Opcion.insert:
                    {
                        if (existe_nombre() == false)
                        {
                            if (validar_campos())
                            {
                                oPrestacion = new Prestacion();
                                oPrestacion.nombre = txtNombre.Text;
                                oPrestacion.cod_prestacion = txtCodigoPrestacion.Text;
                                oPrestacion.descripcion = txtDescripcion.Text;
                                


                                if (oPrestacionService.crearPrestacion(oPrestacion))
                                {
                                    MessageBox.Show("Prestacion  insertada correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Nombre de prestacion encontrada!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                    case Opcion.update:
                    {
                        if (validar_campos())
                        {
                                oPrestacionSelected.cod_prestacion = txtCodigoPrestacion.Text;
                                oPrestacionSelected.nombre = txtNombre.Text;
                                oPrestacionSelected.descripcion = txtDescripcion.Text;
                                

                            if (oPrestacionService.actualizarPrestacion(oPrestacionSelected))
                            {
                                MessageBox.Show("Prestacion actualizada! ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar la prestacion! ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
                    case Opcion.delete:
                    {
                        if (MessageBox.Show("Seguro que desea deshabilitar la prestacion seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            
                                oPrestacionSelected.cod_prestacion = txtCodigoPrestacion.Text;
                                oPrestacionSelected.nombre = txtNombre.Text;
                                oPrestacionSelected.descripcion = txtDescripcion.Text;
                                

                            if (oPrestacionService.modificarEstadoPrestacion(oPrestacionSelected))
                            {
                                MessageBox.Show("Prestacion Deshabilitada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar la prestacion!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
        
}
