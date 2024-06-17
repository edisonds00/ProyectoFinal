using System;
using System.Collections.Generic;
using Negocio.Entidades;

namespace Proyecto_Primer_Parcial.Datos
{
    internal class VehiculoDatos
    {
        private static List<Vehiculo> vehiculos = new List<Vehiculo>();

        public void Agregar(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }

        public Vehiculo ObtenerPorPlaca(string placa)
        {
            return vehiculos.Find(v => v.Placa == placa);
        }

        public void Actualizar(Vehiculo vehiculo)
        {
            Vehiculo vehExistente = ObtenerPorPlaca(vehiculo.Placa);
            if (vehExistente != null)
            {
                vehExistente.Marca = vehiculo.Marca;
                vehExistente.AnoFabricacion = vehiculo.AnoFabricacion;
                vehExistente.Tipo = vehiculo.Tipo;
            }
        }

        public void Eliminar(string placa)
        {
            vehiculos.RemoveAll(v => v.Placa == placa);
        }

        public List<Vehiculo> ObtenerTodos()
        {
            return vehiculos;
        }
    }
}
