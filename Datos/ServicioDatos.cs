using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades; // Importante para poder utilizar la clase Servicio

namespace Proyecto_Primer_Parcial.Datos
{
    internal class ServicioDatos
    {
        private static List<Servicio> servicios = new List<Servicio>();

        // Método para agregar un servicio
        public void Agregar(Servicio servicio)
        {
            servicios.Add(servicio);
        }

        // Método para obtener un servicio por nombre
        public Servicio ObtenerPorNombre(string nombre)
        {
            return servicios.Find(s => s.Nombre == nombre);
        }

        // Método para actualizar un servicio
        public void Actualizar(Servicio servicio)
        {
            Servicio servExistente = servicios.Find(s => s.Nombre == servicio.Nombre) ?? throw new InvalidOperationException($"Cliente con cédula {servicio.Nombre} no encontrado.");
            if (servExistente != null)
            {
                servExistente.Precio = servicio.Precio;
            }
        }

        // Método para eliminar un servicio por nombre
        public void Eliminar(string nombre)
        {
            servicios.RemoveAll(s => s.Nombre == nombre);
        }

        // Método para obtener todos los servicios
        public List<Servicio> ObtenerTodos()
        {
            return servicios;
        }
    }
}
