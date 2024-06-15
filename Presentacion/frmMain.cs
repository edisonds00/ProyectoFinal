
using GestorMantenimientosTaller.View;
using Presentación.Formularios;
using ProyectoPOE.View;

namespace WinFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntegrantes formulario = new frmIntegrantes();
            formulario.Show();
        }


        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroCliente formulario = new frmRegistroCliente();
            formulario.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroMecanico formulario = new frmRegistroMecanico();
            formulario.Show();
        }

        private void nuevoMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroMantenimiento formulario = new frmRegistroMantenimiento();
            formulario.Show();
        }



        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroVehiculo formulario = new frmRegistroVehiculo();
            formulario.Show();
        }
    }
}