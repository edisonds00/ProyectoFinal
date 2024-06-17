using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades; // Importante para poder utilizar la clase Vehiculo

namespace Proyecto_Primer_Parcial.Datos
{
    internal class VehiculoDatos
    {
        private static List<Vehiculo> vehiculos = new List<Vehiculo>();

        // Método para agregar un vehículo
        public void Agregar(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }

        // Método para obtener un vehículo por placa
        public Vehiculo ObtenerPorPlaca(string placa)
        {
            return vehiculos.Find(v => v.Placa == placa) ?? throw new InvalidOperationException($"Cliente con cédula {placa} no encontrado.");
        }

        // Método para actualizar un vehículo
        public void Actualizar(Vehiculo vehiculo)
        {
            Vehiculo vehExistente = vehiculos.Find(v => v.Placa == vehiculo.Placa) ?? throw new InvalidOperationException($"Cliente con cédula {vehiculo.Placa} no encontrado.");
            if (vehExistente != null)
            {
                vehExistente.Marca = vehiculo.Marca;
                vehExistente.AnoFabricacion = vehiculo.AnoFabricacion;
                vehExistente.Tipo = vehiculo.Tipo;
            }
        }

        // Método para eliminar un vehículo por placa
        public void Eliminar(string placa)
        {
            vehiculos.RemoveAll(v => v.Placa == placa);
        }

        // Método para obtener todos los vehículos
        public List<Vehiculo> ObtenerTodos()
        {
            return vehiculos;
        }
    }
}
