using Negocio.Entidades;
using Proyecto_Primer_Parcial.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentación.Formularios
{
    public partial class frmRegistroVehiculo : Form
    {
        int id;
        bool banderanuevo;
        VehiculoDatos vehiculoDatos;

        public frmRegistroVehiculo()
        {
            InitializeComponent();
            vehiculoDatos = new VehiculoDatos();
        }


        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            cargarClientesEnComboBox();
        }

        private void CargarDatosDataGridView()
        {
            dgvVehiculos.DataSource = null;
            dgvVehiculos.DataSource = vehiculoDatos.ObtenerTodos();
        }


        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();
            string marca = txtMarca.Text.Trim();
            string ano = txtAño.Text.Trim();
            string tipo = txtTipo.Text.Trim();

            Vehiculo vehiculo = new Vehiculo(placa, marca, ano, tipo);

            if (banderanuevo)
            {
                vehiculoDatos.Agregar(vehiculo);
            }
            else
            {
                vehiculoDatos.Actualizar(vehiculo);
            }

            // Luego de guardar o actualizar, actualiza el DataGridView y reinicia el formulario
            CargarDatosDataGridView();
            ReiniciarFormulario();
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Sale del método sin hacer nada más
            }

            string placa = dgvVehiculos.SelectedRows[0].Cells["Placa"].Value.ToString();
            vehiculoDatos.Eliminar(placa);

            // Actualiza el DataGridView y reinicia el formulario
            CargarDatosDataGridView();
            ReiniciarFormulario();
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

        private void ReiniciarFormulario()
        {
            txtAño.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            txtTipo.Text = string.Empty;

   
        }

        private void DeshabilitarCampos()
        {
            txtAño.ReadOnly = true;
            txtMarca.ReadOnly = true;
            txtPlaca.ReadOnly = true;
            txtTipo.ReadOnly = true;
        }

        private void HabilitarCampos()
        {
            txtAño.ReadOnly = false;
            txtMarca.ReadOnly = false;
            txtPlaca.ReadOnly = false;
            txtTipo.ReadOnly = false;
        }

        private void ResetearBotones()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = false;
            btnCancelar.Visible = true;
            ReiniciarFormulario();
            HabilitarCampos();
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            banderanuevo = true;
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtAño.Text.Length >= 4 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void soloAlfabeto(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
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


    }
}
