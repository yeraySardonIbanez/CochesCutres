using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CochesCutres.Models
{
    public class Empleados
    {
        private int id;
        private string NIF;
        private string nombre;
        private string apellidos;
        private string telefono;
        private string direccion;
        private string email;

        public string NIF1 { get => NIF; set => NIF = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public int Id { get => id; set => id = value; }

        public List<Empleados> recuperarTodos()
        {
            Conexiones conn = new Conexiones();
            return conn.seleccionarTodosEmpleados();
        }
        public void actualizarEmpleados(Empleados empleado)
        {
            Conexiones conn = new Conexiones();
            conn.actualizarEmpleado(empleado);
        }
        public void insertarEmpleados(Empleados empleado)
        {
            Conexiones conn = new Conexiones();
            conn.insertarEmpleado(empleado);
        }
        public Empleados seleccionarEmpleado(int id)
        {
            Conexiones conn = new Conexiones();
            return conn.seleccionarEmpleado(id);
        }
    }
}