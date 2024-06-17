using System;
using System.Collections.Generic;
using System.Linq;
using Negocio.Entidades; // Ensure you import the correct namespace

namespace Proyecto_Primer_Parcial.Datos
{
    internal class MecanicoDatos
    {
        private static List<Mecanico> mecanicos = new List<Mecanico>();

        public void Agregar(Mecanico mecanico)
        {
            mecanicos.Add(mecanico);
        }

        public Mecanico ObtenerPorCedula(string cedula)
        {
            return mecanicos.FirstOrDefault(m => m.Cedula == cedula);
        }

        public void Actualizar(Mecanico mecanico)
        {
            Mecanico mecanicoExistente = mecanicos.Find(m => m.Cedula == mecanico.Cedula) ?? throw new InvalidOperationException($"Mecánico con cédula {mecanico.Cedula} no encontrado.");

            if (mecanicoExistente != null)
            {
                mecanicoExistente.Apellidos = mecanico.Apellidos;
                mecanicoExistente.Nombres = mecanico.Nombres;
                mecanicoExistente.Cedula = mecanico.Cedula;
                mecanicoExistente.Especialidad = mecanico.Especialidad;
                mecanicoExistente.Jornada = mecanico.Jornada;
            }
            else
            {
                throw new InvalidOperationException($"Mecánico con cédula {mecanico.Cedula} no encontrado.");
            }
        }

        public void Eliminar(string cedula)
        {
            mecanicos.RemoveAll(m => m.Cedula == cedula);
        }

        public List<Mecanico> ObtenerTodos()
        {
            return mecanicos;
        }
    }
}
