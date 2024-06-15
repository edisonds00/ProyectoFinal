using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Negocio.Entidades;

namespace ProyectoPOE.View
{
    public partial class frmInforme : Form
    {
        Mantenimiento mantenimiento;
        public frmInforme(Mantenimiento mantenimiento)
        {
            this.mantenimiento = mantenimiento;
            InitializeComponent();
        }


        private void frmInforme_Load(object sender, EventArgs e)
        {
            cargarDetallesFactura();
            cargarDetallesCliente();
            cargarDetallesMecanico();
            cargarDetallesVehiculo();
            cargarDetallesMantenimiento();
            cargarRepuestos();
            cargarServicios();
            cargarTotal();
        }

        private void cargarDetallesFactura()
        {
            lblCodigo.Text = mantenimiento.Codigo;
            lblFecha.Text = mantenimiento.FechaMant.ToString();
        }

        private void cargarDetallesCliente()
        {
            lblNombreCliente.Text = mantenimiento.Cliente.ToString();
            lblCedulaCliente.Text = mantenimiento.Cliente.Cedula;
            lblTelefonoCliente.Text = mantenimiento.Cliente.Telefono;
            lblDireccion.Text = mantenimiento.Cliente.Direccion;
        }

        private void cargarDetallesMecanico()
        {
            lblNombreMecanico.Text = mantenimiento.Mecanico.ToString();
            lblCedulaMecanico.Text = mantenimiento.Mecanico.Cedula;
            lblJornada.Text = mantenimiento.Mecanico.Jornada;
            lblEspecialidad.Text = mantenimiento.Mecanico.Especialidad;
        }

        private void cargarDetallesVehiculo()
        {
            lblMarca.Text = mantenimiento.Vehiculo.Marca;
            lblPlaca.Text = mantenimiento.Vehiculo.Placa;
            lblTipo.Text = mantenimiento.Vehiculo.Tipo;
            lblAnio.Text = mantenimiento.Vehiculo.AnoFabricacion;
        }

        private void cargarDetallesMantenimiento()
        {
            lblTrabajo.Text = mantenimiento.Trabajo;
            lblDiagnostico.Text = mantenimiento.Diagnostico;
            lblTipoMantenimiento.Text = mantenimiento.EsCorrectivo ? "Corretivo" : "Preventivo";
        }

        private void cargarRepuestos()
        {
            listaRepuesto.Items.Clear();

            foreach (Repuesto repuesto in mantenimiento.Repuestos)
            {
                string[] arr = new string[2];
                arr[0] = repuesto.Nombre;
                arr[1] = "$" + repuesto.Precio.ToString();

                ListViewItem item = new ListViewItem(arr);
                listaRepuesto.Items.Add(item);
            }
        }

        private void cargarServicios()
        {
            listaServicio.Items.Clear();

            foreach (Servicio servicio in mantenimiento.Servicios)
            {
                string[] arr = new string[2];
                arr[0] = servicio.Nombre;
                arr[1] = "$" + servicio.Precio.ToString();

                ListViewItem item = new ListViewItem(arr);
                listaServicio.Items.Add(item);
            }
        }

        private void cargarTotal()
        {
            decimal costoRepuesto = mantenimiento.Repuestos.Sum(repuesto => repuesto.Precio);
            lblCostoRepuesto.Text = costoRepuesto.ToString();

            decimal costoServicio = mantenimiento.Servicios.Sum(servicio => servicio.Precio);
            lblCostoServicio.Text = costoServicio.ToString();

            decimal costoMantenimiento = mantenimiento.EsCorrectivo ? 80 : 40;
            lblCostoMantenimiento.Text = costoMantenimiento.ToString();

            decimal subtotal = costoMantenimiento + costoRepuesto + costoServicio;
            lblSubtotal.Text = subtotal.ToString();

            decimal iva = subtotal * 0.12m;
            lblIva.Text = iva.ToString();

            decimal total = subtotal + iva;
            lblTotal.Text = total.ToString();
        }

    }
}
