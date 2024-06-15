
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Entidades;

namespace GestorMantenimientosTaller.View
{
    public partial class frmRegistroCliente : Form
    {
        bool banderanuevo = false;
        Cliente clienteEncontrado;

        public frmRegistroCliente()
        {;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

        }

        private void ReiniciarFormulario()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtdireccion.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private void DeshabilitarCampos()
        {
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtdireccion.ReadOnly = true;
            txtCedula.ReadOnly = false;
            txtTelefono.ReadOnly = true;
        }

        private void HabilitarCampos()
        {
            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtdireccion.ReadOnly = false;
            txtCedula.ReadOnly = false;
            txtTelefono.ReadOnly = false;
        }

        private void ResetearBotones()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnBuscar.Enabled = true;
            btnEliminar.Enabled = false;
        }


        private void Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtdireccion.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (banderanuevo)
            {
                string nombres = txtNombre.Text;
                string apellidos = txtApellido.Text;
                string direccion = txtdireccion.Text;
                string cedula = txtCedula.Text;
                string telefono = txtTelefono.Text;
                Cliente objCliente = new Cliente(apellidos, nombres, cedula, direccion, telefono);
                
                // Pendiente (Agregar Cliente)

                banderanuevo = false;
                btnNuevo.Visible = true;
                btnCancelar.Visible = false;
            }
            else
            {
                string nombres = txtNombre.Text;
                string apellidos = txtApellido.Text;
                string direccion = txtdireccion.Text;
                string cedula = txtCedula.Text;
                string telefono = txtTelefono.Text;
                Cliente clienteActualizado = new Cliente(apellidos, nombres, cedula, direccion, telefono);

                // Pendiente (Actualizar Cliente)
            }

            DeshabilitarCampos();
            ReiniciarFormulario();
            ResetearBotones();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = false;
            btnCancelar.Visible = true;

            ReiniciarFormulario();
            HabilitarCampos();

            // Botones
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;

            banderanuevo = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;

            // clienteEncontrado = [Pendiente ObtenerCliente]

            if (clienteEncontrado != null)
            {
                HabilitarCampos();

                txtTelefono.Text = clienteEncontrado.Telefono;
                txtdireccion.Text = clienteEncontrado.Direccion;
                txtApellido.Text = clienteEncontrado.Apellidos;
                txtNombre.Text = clienteEncontrado.Nombres;
                txtCedula.Text = clienteEncontrado.Cedula;

                banderanuevo = false;

                // Botones
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Pendiente (Eliminar Cliente)

                ResetearBotones();
                ReiniciarFormulario();
                DeshabilitarCampos();
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

                // Limitar a 10 caracteres
                if (txtCedula.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void soloNumerosTelefono(object sender, KeyPressEventArgs e)
        {
            {
                // Permitir solo números y teclas de control (por ejemplo, retroceso)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                // Limitar a 10 caracteres
                if (txtTelefono.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void soloAlfabeto(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter es una letra, un espacio o no es un control (como la tecla de retroceso)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
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
    }
}

