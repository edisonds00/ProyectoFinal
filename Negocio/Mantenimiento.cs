using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Mantenimiento
    {
        public string Codigo { get; set; }
        public Cliente Cliente { get; set; }
        public Mecanico Mecanico { get; set; }
        public DateTime FechaMant { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public string Diagnostico { get; set; }
        public string Trabajo { get; set; }
        public bool EsCorrectivo { get; set; }
        public Repuesto[] Repuestos { get; set; }
        public Servicio[] Servicios { get; set; }

        public Mantenimiento(string codigo, Cliente cliente, Mecanico mecanico, DateTime fechamant, Vehiculo vehiculo, string diagnostico, string trabajo, bool escorrectivo, Repuesto[] repuestos, Servicio[] servicios)
        {
            this.Codigo = codigo;
            this.Cliente = cliente;
            this.Mecanico = mecanico;
            this.FechaMant = fechamant;
            this.Vehiculo = vehiculo;
            this.Diagnostico = diagnostico;
            this.Trabajo = trabajo;
            this.EsCorrectivo = escorrectivo;
            this.Repuestos = repuestos;
            this.Servicios = servicios;
        }
        
    }
}
