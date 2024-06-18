
using ProyectoPOE.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using Negocio.Entidades;
using Proyecto_Primer_Parcial.Datos;

namespace GestorMantenimientosTaller.View
{
    public partial class frmRegistroMantenimiento : Form
    {
        bool banderanuevo = false;
        Mantenimiento mantenimientoEncontrado;
        int ultimoId = 0;
        public frmRegistroMantenimiento()
        {
            InitializeComponent();

            
            
            

            // Obtener el último ID de la base de datos al inicio
            ultimoId = ObtenerUltimoId();
        }

        private int ObtenerUltimoId()
        {
            // Aquí deberías implementar la lógica para obtener el último ID desde tu base de datos
            // Por ejemplo:
            // var datos = new MantenimientoDatos();
            // int ultimoId = datos.ObtenerUltimoId();
            // return ultimoId;

            // Como ejemplo, devolvemos un valor fijo para propósitos de demostración
            return 0;
        }

        private int GenerarNuevoId()
        {
            // Incrementar el último ID para generar uno nuevo
            ultimoId++;
            return ultimoId;
        }

        private void frmRegistroMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void CargarServicios()
        {
            
        }

        private void CargarRespuestos()
        {
        }

        private void CargarClientes()
        {
            
        }

        private void CargarMecanicos()
        {
            
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            
        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void cargarClientesEnComboBox()
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            List<Cliente> clientes = clienteDatos.ObtenerTodos();
            cbClientes.Items.Clear();
            foreach (Cliente cliente in clientes)
            {
                string nombreCompleto = cliente.Nombres + " " + cliente.Apellidos;
                cbClientes.Items.Add(nombreCompleto);
            }
            if (clientes.Count > 0)
            {
                cbClientes.SelectedIndex = 0;
            }
        }

        private void cargarMecanicosEnComboBox()
        {
            MecanicoDatos mecanicoDatos = new MecanicoDatos();
            List<Mecanico> mecánicos = mecanicoDatos.ObtenerTodos();
            cbMecanicos.Items.Clear();
            foreach (Mecanico mecanico in mecánicos)
            {
                string nombreCompleto = $"{mecanico.Nombres} {mecanico.Apellidos}";
                cbMecanicos.Items.Add(nombreCompleto);
            }
            if (mecánicos.Count > 0)
            {
                cbMecanicos.SelectedIndex = 0;
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void ReiniciarFormulario()
        {
            txtId.Text = string.Empty;
            dtpFecha.Text = string.Empty;
            cbClientes.Text = string.Empty;
            cbMecanicos.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtAño.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtDiagnostico.Text = string.Empty;
            rtbTrabajo.Text = string.Empty;
            rdbCorrectivo.Checked = false;
            rdbPreventivo.Checked = false;
            repuestosBox.Visible = false;

            for (int i = 0; i < clbServicios.Items.Count; i++)
            {
                clbServicios.SetItemChecked(i, false);
            }

            for (int i = 0; i < clbRepuestos.Items.Count; i++)
            {
                clbRepuestos.SetItemChecked(i, false);
            }
        }

        private void DeshabilitarCampos()
        {
            txtId.ReadOnly = false;
            dtpFecha.Enabled = false;
            cbClientes.Enabled = false;
            cbMecanicos.Enabled = false;
            txtPlaca.ReadOnly = true;
            txtMarca.ReadOnly = true;
            txtAño.ReadOnly = true;
            txtTipo.ReadOnly = true;
            txtDiagnostico.ReadOnly = true;
            rtbTrabajo.ReadOnly = true;
            rdbCorrectivo.Enabled = false;
            rdbPreventivo.Enabled = false;
            clbRepuestos.Enabled = false;
            clbServicios.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtId.ReadOnly = false;
            dtpFecha.Enabled = true;
            cbClientes.Enabled = true;
            cbMecanicos.Enabled = true;
            txtPlaca.ReadOnly = false;
            txtMarca.ReadOnly = false;
            txtAño.ReadOnly = false;
            txtTipo.ReadOnly = false;
            txtDiagnostico.ReadOnly = false;
            rtbTrabajo.ReadOnly = false;
            rdbCorrectivo.Enabled = true;
            rdbPreventivo.Enabled = true;
            clbRepuestos.Enabled = true;
            clbServicios.Enabled = true;
        }

        private void ResetearBotones()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnBuscar.Enabled = true;
            btnEliminar.Enabled = false;
            btnMostrar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = false;
            btnCancelar.Visible = true;

            ReiniciarFormulario();
            HabilitarCampos();

            // Cargar clientes y mecánicos en ComboBox
            CargarClientes();
            CargarMecanicos();

            // Generar nuevo ID
            txtId.Text = GenerarNuevoId().ToString();

            // Botones
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            banderanuevo = true;

            cargarClientesEnComboBox();
            cargarMecanicosEnComboBox();
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (mantenimientoEncontrado != null)
            {
                frmInforme informe = new frmInforme(mantenimientoEncontrado);
                informe.Show();
            }
            else
            {
                MessageBox.Show("No se ha encontrado ningún mantenimiento para mostrar.");
            }
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            {
                // Permitir solo números y teclas de control (por ejemplo, retroceso)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void soloAlfabeto(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter es una letra y no es un control (como la tecla de retroceso)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = true;
            btnCancelar.Visible = false;

            ResetearBotones();
            ReiniciarFormulario();
            DeshabilitarCampos();
            banderanuevo = false;
        }

        private void rdbCorrectivo_CheckedChanged(object sender, EventArgs e)
        {
            repuestosBox.Visible = true;
        }

        private void rdbPreventivo_CheckedChanged(object sender, EventArgs e)
        {
            repuestosBox.Visible = false;
        }

        
    }
}
