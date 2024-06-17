using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades;


namespace Proyecto_Primer_Parcial.Datos
{
    internal class ClienteDatos
    {
        private static List<Cliente> clientes = new List<Cliente>();

        // Agregar un cliente
        public void Agregar(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        // Obtener cliente por cédula
        public Cliente ObtenerPorCedula(string cedula)
        {
            return clientes.FirstOrDefault(c => c.Cedula == cedula);
        }



        // Actualizar cliente
        public void Actualizar(Cliente cliente)
        {
            Cliente clienteExistente = clientes.Find(c => c.Cedula == cliente.Cedula) ?? throw new InvalidOperationException($"Cliente con cédula {cliente.Cedula} no encontrado.");
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