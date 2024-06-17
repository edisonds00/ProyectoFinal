using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades; // Importante para poder utilizar la clase Repuesto

namespace Proyecto_Primer_Parcial.Datos
{
    internal class RepuestoDatos
    {
        private static List<Repuesto> repuestos = new List<Repuesto>();

        // Método para agregar un repuesto
        public void Agregar(Repuesto repuesto)
        {
            repuestos.Add(repuesto);
        }

        // Método para obtener un repuesto por nombre
        public Repuesto ObtenerPorNombre(string nombre)
        {
            return repuestos.Find(r => r.Nombre == nombre) ?? throw new InvalidOperationException($"Cliente con cédula {nombre} no encontrado.");
        }

        // Método para actualizar un repuesto
        public void Actualizar(Repuesto repuesto)
        {
            Repuesto repExistente = repuestos.Find(r => r.Nombre == repuesto.Nombre) ?? throw new InvalidOperationException($"Cliente con cédula {repuesto.Nombre} no encontrado.");
            if (repExistente != null)
            {
                repExistente.Precio = repuesto.Precio;
            }
        }

        // Método para eliminar un repuesto por nombre
        public void Eliminar(string nombre)
        {
            repuestos.RemoveAll(r => r.Nombre == nombre);
        }

        // Método para obtener todos los repuestos
        public List<Repuesto> ObtenerTodos()
        {
            return repuestos;
        }
    }
}
