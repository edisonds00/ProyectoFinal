using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades;

namespace Proyecto_Primer_Parcial.Datos
{
    internal class MantenimientoDatos
    {
        private static List<Mantenimiento> mantenimientos = new List<Mantenimiento>();

        // Agregar un mantenimiento
        public void Agregar(Mantenimiento mantenimiento)
        {
            mantenimientos.Add(mantenimiento);
        }

        // Obtener mantenimiento por código
        public Mantenimiento ObtenerPorCodigo(string codigo)
        {
            return mantenimientos.Find(m => m.Codigo == codigo) ?? throw new InvalidOperationException($"Cliente con cédula {codigo} no encontrado.");
        }

        // Actualizar mantenimiento
        public void Actualizar(Mantenimiento mantenimiento)
        {
            Mantenimiento mantExistente = mantenimientos.Find(m => m.Codigo == mantenimiento.Codigo) ?? throw new InvalidOperationException($"Cliente con cédula {mantenimiento.Codigo} no encontrado.");
            if (mantExistente != null)
            {
                mantExistente.Cliente = mantenimiento.Cliente;
                mantExistente.Mecanico = mantenimiento.Mecanico;
                mantExistente.FechaMant = mantenimiento.FechaMant;
                mantExistente.Vehiculo = mantenimiento.Vehiculo;
                mantExistente.Diagnostico = mantenimiento.Diagnostico;
                mantExistente.Trabajo = mantenimiento.Trabajo;
                mantExistente.EsCorrectivo = mantenimiento.EsCorrectivo;
                mantExistente.Repuestos = mantenimiento.Repuestos;
                mantExistente.Servicios = mantenimiento.Servicios;
            }
        }

        // Eliminar mantenimiento por código
        public void Eliminar(string codigo)
        {
            mantenimientos.RemoveAll(m => m.Codigo == codigo);
        }

        // Obtener todos los mantenimientos
        public List<Mantenimiento> ObtenerTodos()
        {
            return mantenimientos;
        }
    }
}