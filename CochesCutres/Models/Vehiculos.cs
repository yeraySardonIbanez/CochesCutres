using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace CochesCutres.Models
{
    public class Vehiculos
    {
        private int id;
        private string marca;
        private string modelo;
        private int n_puertas;
        private string color;
        private int km;
        private Tipo_Vehiculo tipo_vehiculo;
        private int garantia;
        private string fotografia;

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int N_puertas { get => n_puertas; set => n_puertas = value; }
        public string Color { get => color; set => color = value; }
        public int Km { get => km; set => km = value; }
        public Tipo_Vehiculo Tipo_vehiculo { get => tipo_vehiculo; set => tipo_vehiculo = value; }
        public int Garantia { get => garantia; set => garantia = value; }
        public string Fotografia { get => fotografia; set => fotografia = value; }


        public List<Vehiculos> recuperarTodos()
        {
            Conexiones conn = new Conexiones();
            return conn.seleccionarTodosVehiculos();
        }
        public void actualizarVehiculo(Vehiculos vehiculo)
        {
            Conexiones conn = new Conexiones();
            conn.actualizarVehiculo(vehiculo);
        }
        public Vehiculos recuperarVehiculo(int id)
        {
            Conexiones conn = new Conexiones();
            return conn.seleccionarVehiculo(id);
        }
    }
    public enum Tipo_Vehiculo { Utilitario,Cupe,Familiar,SUV,Industrial}

}