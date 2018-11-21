using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1_AO_2018.GUILayer
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GUILayer.Reportes.frmRepPacientesXOdontologo().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new GUILayer.Reportes.frmRepArreglosXPaciente().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new GUILayer.Reportes.frmRepoUsuariosXPerfil().ShowDialog();
        }

        private void btnRepHistoriasCliXFecha_Click(object sender, EventArgs e)
        {
            new GUILayer.Reportes.frmRepPrestacionesEntreFechas().ShowDialog();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new GUILayer.Reportes.FrmRepCantidadPrestaciones().ShowDialog();
        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    new GUILayer.Reportes.FrmRepoIngreso().ShowDialog();
        //}

        private void btnPrestacionesPorOdontologo_Click(object sender, EventArgs e)
        {
            new GUILayer.Reportes.FrmPrestacionesporOdontologo().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new GUILayer.Reportes.FrmIngresoporPrestacion().ShowDialog();
        }

        private void btnAportes_Click(object sender, EventArgs e)
        {
            new GUILayer.Reportes.FrmAportesXOdontolgo().ShowDialog();
        }
    }
}
