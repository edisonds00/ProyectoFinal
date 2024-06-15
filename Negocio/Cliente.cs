using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Cliente : Persona
    {
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Cliente(string apellidos, string nombres, string cedula, string direccion, string telefono)
                : base(apellidos, nombres, cedula)
        {
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
