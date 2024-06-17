using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades;

namespace Proyecto_Primer_Parcial.Datos
{
    internal class MecanicoDatos
    {
        private static List<Mecanico> mecanicos = new List<Mecanico>();

        // Agregar un mecánico
        public void Agregar(Mecanico mecanico)
        {
            mecanicos.Add(mecanico);
        }

        // Obtener mecánico por cédula
        public Mecanico ObtenerPorCedula(string cedula)
        {
            return mecanicos.Find(m => m.Cedula == cedula) ?? throw new InvalidOperationException($"Cliente con cédula {cedula} no encontrado.");
        }

        // Actualizar mecánico
        public void Actualizar(Mecanico mecanico)
        {
            Mecanico mecExistente = mecanicos.Find(m => m.Cedula == mecanico.Cedula) ?? throw new InvalidOperationException($"Cliente con cédula {mecanico.Cedula} no encontrado.");
            if (mecExistente != null)
            {
                mecExistente.Apellidos = mecanico.Apellidos;
                mecExistente.Nombres = mecanico.Nombres;
                mecExistente.Especialidad = mecanico.Especialidad;
                mecExistente.Jornada = mecanico.Jornada;
            }
        }

        // Eliminar mecánico por cédula
        public void Eliminar(string cedula)
        {
            mecanicos.RemoveAll(m => m.Cedula == cedula);
        }

        // Obtener todos los mecánicos
        public List<Mecanico> ObtenerTodos()
        {
            return mecanicos;
        }
    }
}
