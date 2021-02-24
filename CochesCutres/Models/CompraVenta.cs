using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CochesCutres.Models
{
    public class CompraVenta
    {
        private int id;
        private DateTime fecha;
        private Tipo tipo;
        private int empleado;
        private int cliente;
        private float precio;

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Tipo Tipo { get => tipo; set => tipo = value; }
        public int Empleado { get => empleado; set => empleado = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public float Precio { get => precio; set => precio = value; }

        public List<CompraVenta> recuperarTodos()
        {
            Conexiones conn = new Conexiones();
            return conn.seleccionarCompraVenta();
        }

        public void añadirCompraVenta(CompraVenta compraVenta)
        {
            Conexiones conn = new Conexiones();
            conn.insertarCompraVenta(compraVenta);
        }

    }
    public enum Tipo { Compra,Venta}
}