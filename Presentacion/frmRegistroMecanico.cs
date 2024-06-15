
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
    public partial class frmRegistroMecanico : Form
    {
        bool banderanuevo = false;
        Mecanico mecanicoEncontrado;

        public frmRegistroMecanico()
        {
            InitializeComponent();

            // Agregar opciones a cbxEspecialidadMecanico
            cbxEspecialidadMecanico.Items.Add("Mecánica automotriz general");
            cbxEspecialidadMecanico.Items.Add("Mecánica de motores diésel");
            cbxEspecialidadMecanico.Items.Add("Mecánica de sistemas eléctricos y electrónicos");

            // Agregar opciones a cbxJornadaMecanico
            cbxJornadaMecanico.Items.Add("Matutina");
            cbxJornadaMecanico.Items.Add("Vespertina");
            cbxJornadaMecanico.Items.Add("Nocturna");

            btnGuardarMecanico.Enabled = false;
            btnEliminarMecanico.Enabled = false;
        }

        private void ReiniciarFormulario()
        {
            txtNombreMecanico.Text = string.Empty;
            txtApellidoMecanico.Text = string.Empty;
            txtCedulaMecanico.Text = string.Empty;

            cbxEspecialidadMecanico.SelectedIndex = -1;
            cbxJornadaMecanico.SelectedIndex = -1;
        }

        private void DeshabilitarCampos()
        {
            txtNombreMecanico.ReadOnly = true;
            txtApellidoMecanico.ReadOnly = true;
            txtCedulaMecanico.ReadOnly = false;

            cbxJornadaMecanico.Enabled = false;
            cbxEspecialidadMecanico.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtNombreMecanico.ReadOnly = false;
            txtApellidoMecanico.ReadOnly = false;
            txtCedulaMecanico.ReadOnly = false;

            cbxJornadaMecanico.Enabled = true;
            cbxEspecialidadMecanico.Enabled = true;
        }

        private void ResetearBotones()
        {
            btnNuevo.Enabled = true;
            btnGuardarMecanico.Enabled = false;
            btnBuscarMecanico.Enabled = true;
            btnEliminarMecanico.Enabled = false;
        }

        private void btnGuardarMecanico_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreMecanico.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoMecanico.Text) ||
                string.IsNullOrWhiteSpace(txtCedulaMecanico.Text) ||
                cbxEspecialidadMecanico.SelectedItem == null ||
                cbxJornadaMecanico.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (banderanuevo)
            {
                string nombres = txtNombreMecanico.Text;
                string apellidos = txtApellidoMecanico.Text;
                string cedula = txtCedulaMecanico.Text;
                string especialidad = cbxEspecialidadMecanico.SelectedItem.ToString();
                string jornada = cbxJornadaMecanico.SelectedItem.ToString();

                Mecanico objMecanico = new Mecanico(apellidos, nombres, cedula, especialidad, jornada);

                // Pendiente (Agregar Mecánico)

                banderanuevo = false;
                btnNuevo.Visible = true;
                btnCancelar.Visible = false;
            }
            else
            {
                string nombres = txtNombreMecanico.Text;
                string apellidos = txtApellidoMecanico.Text;
                string cedula = txtCedulaMecanico.Text;
                string especialidad = cbxEspecialidadMecanico.SelectedItem.ToString();
                string jornada = cbxJornadaMecanico.SelectedItem.ToString();

                Mecanico mecanicoActualizado = new Mecanico(apellidos, nombres, cedula, especialidad, jornada);

                // Actualizar (Agregar Mecánico)
            }

            DeshabilitarCampos();
            ReiniciarFormulario();
            ResetearBotones();
        }


        private void btnCancelarMecanico_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = true;
            btnCancelar.Visible = false;

            ResetearBotones();
            ReiniciarFormulario();
            DeshabilitarCampos();
            banderanuevo = false;
        }


        private void btnBuscarMecanico_Click(object sender, EventArgs e)
        {
            string cedula = txtCedulaMecanico.Text;

            // mecanicoEncontrado = // Pendiente (Obtener Mecánico)

            if (mecanicoEncontrado != null)
            {
                HabilitarCampos();

                cbxEspecialidadMecanico.SelectedItem = mecanicoEncontrado.Especialidad;
                cbxJornadaMecanico.SelectedItem = mecanicoEncontrado.Jornada;
                txtApellidoMecanico.Text = mecanicoEncontrado.Apellidos;
                txtNombreMecanico.Text = mecanicoEncontrado.Nombres;
                txtCedulaMecanico.Text = mecanicoEncontrado.Cedula;

                banderanuevo = false;

                // Botones
                btnGuardarMecanico.Enabled = true;
                btnEliminarMecanico.Enabled = true;
            }
            else
            {
                MessageBox.Show("Mecánico no encontrado.");
            }
        }


        private void btnEliminarMecanico_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este mecánico?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                // Pendiente (Eliminar Mecánico)

                ResetearBotones();
                ReiniciarFormulario();
                DeshabilitarCampos();
            }
        }

        private void btnNuevoMecanico_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = false;
            btnCancelar.Visible = true;

            ReiniciarFormulario();
            HabilitarCampos();

            // Botones
            btnNuevo.Enabled = false;
            btnGuardarMecanico.Enabled = true;
            btnBuscarMecanico.Enabled = false;
            btnEliminarMecanico.Enabled = false;

            banderanuevo = true;
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (por ejemplo, retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limitar a 10 caracteres
            if (txtCedulaMecanico.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
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



    }
}
