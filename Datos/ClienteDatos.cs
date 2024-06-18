using System;
using System.Collections.Generic;
using System.Linq;
using Negocio.Entidades; // Asegúrate de importar la clase Cliente desde Negocio.Entidades

namespace Proyecto_Primer_Parcial.Datos
{
    internal class ClienteDatos
    {
        private static List<Cliente> clientes = new List<Cliente>();

        // Constructor estático para inicializar algunos clientes de ejemplo
        static ClienteDatos()
        {
            // Ejemplo de clientes predefinidos
            clientes.Add(new Cliente("Juan", "Perez", "123456789", "Dirección de Juan", "555-1234"));
            clientes.Add(new Cliente("Maria", "Gomez", "987654321", "Dirección de Maria", "555-5678"));
        }

        // Agregar un cliente
        public void Agregar(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente), "El cliente no puede ser nulo.");
            }

            // Validar si ya existe un cliente con la misma cédula
            if (ObtenerPorCedula(cliente.Cedula) != null)
            {
                throw new InvalidOperationException($"Ya existe un cliente con la cédula {cliente.Cedula}.");
            }

            clientes.Add(cliente);
        }

        // Obtener cliente por cédula
        public Cliente ObtenerPorCedula(string cedula)
        {
            return clientes.FirstOrDefault(c => c.Cedula == cedula);
        }

        public Cliente ObtenerPorNombre(string nombreCompleto)
        {
            return clientes.Find(c => (c.Nombres + " " + c.Apellidos) == nombreCompleto);
        }


        // Actualizar cliente
        public void Actualizar(Cliente cliente)
        {
            Cliente clienteExistente = clientes.Find(c => c.Cedula == cliente.Cedula);
            if (clienteExistente != null)
            {
                clienteExistente.Apellidos = cliente.Apellidos ?? clienteExistente.Apellidos;
                clienteExistente.Nombres = cliente.Nombres ?? clienteExistente.Nombres;
                clienteExistente.Direccion = cliente.Direccion ?? clienteExistente.Direccion;
                clienteExistente.Telefono = cliente.Telefono ?? clienteExistente.Telefono;
            }
            else
            {
                throw new InvalidOperationException($"Cliente con cédula {cliente.Cedula} no encontrado.");
            }
        }

        // Eliminar cliente por cédula
        public void Eliminar(string cedula)
        {
            clientes.RemoveAll(c => c.Cedula == cedula);
        }

        // Obtener todos los clientes
        public List<Cliente> ObtenerTodos()
        {
            return clientes;
        }
    }
}
