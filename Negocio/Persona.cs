using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public abstract class Persona
    {
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }

        public Persona(string apellidos, string nombres, string cedula)
        {
            Apellidos = apellidos;
            Nombres = nombres;
            Cedula = cedula;
        }

        public override string ToString()
        {
            return $"{Apellidos} {Nombres}";
        }
    }
}
