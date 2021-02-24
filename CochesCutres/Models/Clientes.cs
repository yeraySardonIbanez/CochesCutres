using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CochesCutres.Models
{
    public class Clientes
    {
        private int id;
        private string nif;
        private string nombre;
        private string apellidos;
        private string telefono;
        private string direccion;
        private string email;

        public string NIF { get => nif; set => nif = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public int Id { get => id; set => id = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public List<Clientes> recuperarTodos()
        {
            Conexiones conn = new Conexiones();
            return conn.seleccionarTodosClientes();
        }
        public void actualizarClientes(Clientes cliente)
        {
            Conexiones conn = new Conexiones();
            conn.actualizarCliente(cliente);
        }
        public void insertarCliente(Clientes cliente)
        {
            Conexiones conn = new Conexiones();
            conn.insertarCliente(cliente);
        }
        public Clientes seleccionarCliente(int id)
        {
            Conexiones conn = new Conexiones();
            return conn.seleccionarCliente(id);
        }

    }
    
}