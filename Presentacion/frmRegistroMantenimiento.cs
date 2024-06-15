
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

namespace GestorMantenimientosTaller.View
{
    public partial class frmRegistroMantenimiento : Form
    {
        bool banderanuevo = false;
        Mantenimiento mantenimientoEncontrado;
        public frmRegistroMantenimiento()
        {
            InitializeComponent();

            CargarClientes();
            CargarMecanicos();
            CargarServicios();
            CargarRespuestos();
        }

        private void frmRegistroMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void CargarServicios()
        {
            // Pendiente (Obtener Servicios)
            
            /*
            clbServicios.Items.AddRange(servicios);
            clbServicios.DisplayMember = "Nombre";
            */
        }

        private void CargarRespuestos()
        {
            // Pendiente (Obtener Repuestos)

            /*
            clbRepuestos.Items.AddRange(repuestos);
            clbRepuestos.DisplayMember = "Nombre";
            */
        }

        private void CargarClientes()
        {
            // Pendiente (Obtener Clientes)

            /*
            foreach (Cliente cliente in clientes.GetClientes())
            {
                cmbCliente.Items.Add(cliente);
            }
            */
        }

        private void CargarMecanicos()
        {
            // Pendiente (Obtener Mecánicos)

            /*
            foreach (Mecanico mecanico in mecanicos.GetMecanicos())
            {
                cmbMecanico.Items.Add(mecanico);
            }
            */
        }

        private void ReiniciarFormulario()
        {

            txtId.Text = string.Empty;
            dtpFecha.Text = string.Empty;
            cmbCliente.Text = string.Empty;
            cmbMecanico.Text = string.Empty;
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
            cmbCliente.Enabled = false;
            cmbMecanico.Enabled = false;
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
            cmbCliente.Enabled = true;
            cmbMecanico.Enabled = true;
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


        private void Guardar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem == null ||
                cmbMecanico.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtAño.Text) ||
                string.IsNullOrWhiteSpace(txtTipo.Text) ||
                string.IsNullOrWhiteSpace(txtDiagnostico.Text) ||
                string.IsNullOrWhiteSpace(rtbTrabajo.Text) ||
                rdbCorrectivo == null ||
                rdbPreventivo == null ||
                clbRepuestos == null ||
                clbServicios == null ||
                dtpFecha.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (banderanuevo)
            {

                string codigo = txtId.Text;
                Cliente clienteSeleccionado = (Cliente)cmbCliente.SelectedItem;
                Mecanico mecanicoSeleccionado = (Mecanico)cmbMecanico.SelectedItem;
                DateTime fecha = dtpFecha.Value;
                string placa = txtPlaca.Text;
                string marca = txtMarca.Text;
                string ano = txtAño.Text;
                string tipo = txtTipo.Text;
                Vehiculo objvehiculo = new Vehiculo(placa, marca, ano, tipo);
                string diagnostico = txtDiagnostico.Text;
                string trabajo = rtbTrabajo.Text;
                bool correctivo = false;
                if (rdbCorrectivo.Checked)
                {
                    correctivo = true;
                }
                List<Repuesto> repuestosSeleccionados = new List<Repuesto>();

                foreach (Repuesto repuesto in clbRepuestos.CheckedItems)
                {
                    repuestosSeleccionados.Add(repuesto);
                }
                Repuesto[] arregloRepuestos = repuestosSeleccionados.ToArray();

                List<Servicio> serviciosSeleccionados = new List<Servicio>();
                foreach (Servicio servicio in clbServicios.CheckedItems)
                {
                    serviciosSeleccionados.Add(servicio);
                }
                Servicio[] arregloServicios = serviciosSeleccionados.ToArray();
                Mantenimiento objmantenimiento = new Mantenimiento(codigo, clienteSeleccionado, mecanicoSeleccionado, fecha, objvehiculo, diagnostico, trabajo, correctivo, arregloRepuestos, arregloServicios);
                
                // Pendiente (Crear Mantenimiento)
                // Pendiente (Asociar Servicios)
                // Pendiente (Asociar Repuestos)

                frmInforme nuevoInforme = new frmInforme(objmantenimiento);
                nuevoInforme.Show();

                banderanuevo = false;
                btnNuevo.Visible = true;
                btnCancelar.Visible = false;
            }
            else
            {
                string codigo = txtId.Text;
                Cliente clienteSeleccionado = (Cliente)cmbCliente.SelectedItem;
                Mecanico mecanicoSeleccionado = (Mecanico)cmbMecanico.SelectedItem;
                DateTime fecha = dtpFecha.Value;
                string placa = txtPlaca.Text;
                string marca = txtMarca.Text;
                string ano = txtAño.Text;
                string tipo = txtTipo.Text;
                Vehiculo vehiculoActualizado = new Vehiculo(placa, marca, ano, tipo);
                string diagnostico = txtDiagnostico.Text;
                string trabajo = rtbTrabajo.Text;
                bool correctivo = false;
                if (rdbCorrectivo.Checked)
                {
                    correctivo = true;
                }
                List<Repuesto> repuestosActualizados = new List<Repuesto>();

                foreach (Repuesto repuesto in clbRepuestos.CheckedItems)
                {
                    repuestosActualizados.Add(repuesto);
                }
                Repuesto[] arregloRepuestosAct = repuestosActualizados.ToArray();

                List<Servicio> serviciosActualizados = new List<Servicio>();
                foreach (Servicio servicio in clbServicios.CheckedItems)
                {
                    serviciosActualizados.Add(servicio);
                }
                Servicio[] arregloServiciosAct = serviciosActualizados.ToArray();
                Mantenimiento mantenimientoActualizado = new Mantenimiento(codigo, clienteSeleccionado, mecanicoSeleccionado, fecha, vehiculoActualizado, diagnostico, trabajo, correctivo, arregloRepuestosAct, arregloServiciosAct);

                // Pendiente (Actualizar Mantenimiento)
                // Pendiente (Asociar o Desasociar Servicios)
                // Pendiente (Asociar o Desasociar Repuestos)

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
            string codigo = txtId.Text;
            // mantenimientoEncontrado = Pendiente (Obtener Mantenimiento)

            if (mantenimientoEncontrado != null)
            {
                // Limpiar selecciones anteriores
                for (int i = 0; i < clbServicios.Items.Count; i++)
                {
                    clbServicios.SetItemChecked(i, false);
                }

                for (int i = 0; i < clbRepuestos.Items.Count; i++)
                {
                    clbRepuestos.SetItemChecked(i, false);
                }

                HabilitarCampos();
                txtId.Text = mantenimientoEncontrado.Codigo;
                dtpFecha.Text = mantenimientoEncontrado.FechaMant.ToString();
                cmbCliente.Text = mantenimientoEncontrado.Cliente.ToString();
                cmbMecanico.Text = mantenimientoEncontrado.Mecanico.ToString();
                txtPlaca.Text = mantenimientoEncontrado.Vehiculo.Placa;
                txtMarca.Text = mantenimientoEncontrado.Vehiculo.Marca;
                txtAño.Text = mantenimientoEncontrado.Vehiculo.AnoFabricacion;
                txtTipo.Text = mantenimientoEncontrado.Vehiculo.Tipo;
                txtDiagnostico.Text = mantenimientoEncontrado.Diagnostico;
                rtbTrabajo.Text = mantenimientoEncontrado.Trabajo;

                if (mantenimientoEncontrado.EsCorrectivo)
                {
                    rdbCorrectivo.Checked = true;

                }
                else
                {
                    rdbPreventivo.Checked = true;
                }

                // Marcar los servicios seleccionados
                foreach (Servicio servicio in mantenimientoEncontrado.Servicios)
                {
                    int index = clbServicios.Items.IndexOf(servicio);
                    if (index != -1)
                    {
                        clbServicios.SetItemChecked(index, true);
                    }
                }

                // Marcar los repuestos seleccionados (solo si es correctivo)
                if (mantenimientoEncontrado.EsCorrectivo)
                {
                    repuestosBox.Visible = true;

                    foreach (Repuesto repuesto in mantenimientoEncontrado.Repuestos)
                    {
                        int index = clbRepuestos.Items.IndexOf(repuesto);
                        if (index != -1)
                        {
                            clbRepuestos.SetItemChecked(index, true);
                        }
                    }
                }
                else
                {
                    repuestosBox.Visible = false;
                }

                banderanuevo = false;

                // Botones
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
                btnMostrar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Mantenimiento no encontrado.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este manteniemiento?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                // Pendiente (Eliminar Mantenimiento)

                ResetearBotones();
                ReiniciarFormulario();
                DeshabilitarCampos();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmInforme informe = new frmInforme(mantenimientoEncontrado);
            informe.Show();
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
