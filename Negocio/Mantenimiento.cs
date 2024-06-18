using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Mantenimiento
    {
        public string Codigo { get; set; } // Cambiado a setter público para poder asignar desde MantenimientoDatos
        public Cliente Cliente { get; set; }
        public Mecanico Mecanico { get; set; }
        public DateTime FechaMant { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public string Diagnostico { get; set; }
        public string Trabajo { get; set; }
        public bool EsCorrectivo { get; set; }
        public Repuesto[] Repuestos { get; set; }
        public Servicio[] Servicios { get; set; }

        // Constructor para inicializar las propiedades
        public Mantenimiento(string codigo, Cliente cliente, Mecanico mecanico, DateTime fechaMant, Vehiculo vehiculo, string diagnostico, string trabajo, bool esCorrectivo, Repuesto[] repuestos, Servicio[] servicios)
        {
            Codigo = codigo;
            Cliente = cliente;
            Mecanico = mecanico;
            FechaMant = fechaMant;
            Vehiculo = vehiculo;
            Diagnostico = diagnostico;
            Trabajo = trabajo;
            EsCorrectivo = esCorrectivo;
            Repuestos = repuestos;
            Servicios = servicios;
        }
    }
}
