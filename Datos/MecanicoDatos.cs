using System;
using System.Collections.Generic;
using System.Linq;
using Negocio.Entidades; // Asegúrate de importar la clase Mecanico desde Negocio.Entidades

namespace Proyecto_Primer_Parcial.Datos
{
    internal class MecanicoDatos
    {
        private static List<Mecanico> mecanicos = new List<Mecanico>();

        // Constructor estático para inicializar algunos mecánicos de ejemplo
        static MecanicoDatos()
        {
            // Ejemplo de mecánicos predefinidos
            mecanicos.Add(new Mecanico("Carlos", "González", "123456789", "Mecánico automotriz", "Mañana"));
            mecanicos.Add(new Mecanico("Laura", "Martínez", "987654321", "Mecánico de motocicletas", "Tarde"));
        }

        // Agregar un mecánico
        public void Agregar(Mecanico mecanico)
        {
            if (mecanico == null)
            {
                throw new ArgumentNullException(nameof(mecanico), "El mecánico no puede ser nulo.");
            }

            // Validar si ya existe un mecánico con la misma cédula
            if (ObtenerPorCedula(mecanico.Cedula) != null)
            {
                throw new InvalidOperationException($"Ya existe un mecánico con la cédula {mecanico.Cedula}.");
            }

            mecanicos.Add(mecanico);
        }

        // Obtener mecánico por cédula
        public Mecanico ObtenerPorCedula(string cedula)
        {
            return mecanicos.FirstOrDefault(m => m.Cedula == cedula);
        }

        // Actualizar mecánico
        public void Actualizar(Mecanico mecanico)
        {
            Mecanico mecanicoExistente = mecanicos.Find(m => m.Cedula == mecanico.Cedula);
            if (mecanicoExistente != null)
            {
                mecanicoExistente.Apellidos = mecanico.Apellidos ?? mecanicoExistente.Apellidos;
                mecanicoExistente.Nombres = mecanico.Nombres ?? mecanicoExistente.Nombres;
                mecanicoExistente.Especialidad = mecanico.Especialidad ?? mecanicoExistente.Especialidad;
                mecanicoExistente.Jornada = mecanico.Jornada ?? mecanicoExistente.Jornada;
            }
            else
            {
                throw new InvalidOperationException($"Mecánico con cédula {mecanico.Cedula} no encontrado.");
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
