using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación.Formularios
{
    public partial class frmRegistroVehiculo : Form
    {
        int id;
       
        bool banderanuevo;
        public frmRegistroVehiculo()
        {
            InitializeComponent();
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarVehículos();
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtAño.Text = dgvVehiculos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMarca.Text = dgvVehiculos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPlaca.Text = dgvVehiculos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTipo.Text = dgvVehiculos.Rows[e.RowIndex].Cells[5].Value.ToString();

                banderanuevo = false;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
                HabilitarCampos();

                id = Convert.ToInt32(dgvVehiculos.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void cargarClientes()
        {
            
        }

        private void cargarVehículos()
        {
            
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
            btnEliminar.Enabled = false;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {

           
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
            btnEliminar.Enabled = false;

            banderanuevo = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            {
                // Permitir solo números y teclas de control (por ejemplo, retroceso)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                // Limitar a 4 caracteres
                if (txtAño.Text.Length >= 4 && e.KeyChar != (char)Keys.Back)
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
                if (txtAño.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
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
