using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Servicio
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Servicio(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

    }


}
