using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;

namespace CochesCutres.Models
{
    public class Conexiones
    {
        SqlConnection conexion=null;
        string conectionString = ConfigurationManager.ConnectionStrings["cochescutres"].ConnectionString;
        public Conexiones()
        {
            
            if (conexion == null) {
                conexion = new SqlConnection();
                conexion.ConnectionString = conectionString;
            }
        }
        #region Clientes
        public List<Clientes> seleccionarTodosClientes()
        {

            conexion.Open();
            List<Clientes> resultado;
            SqlCommand cmdSQL = new SqlCommand("SELECT * FROM Clientes", conexion);
            SqlDataAdapter daSQL = new SqlDataAdapter(cmdSQL);

            DataSet ds = new DataSet();
            daSQL.Fill(ds);
            resultado = ds.Tables[0].AsEnumerable()
            .Select(dataRow => new Clientes
            {
                NIF = dataRow.Field<string>("NIF"),
                Id = dataRow.Field<int>("ID"),
                Nombre = dataRow.Field<string>("NOMBRE"),
                Apellidos = dataRow.Field<string>("APELLIDOS"),
                Telefono = dataRow.Field<string>("TELEFONO"),
                Direccion = dataRow.Field<string>("DIRECCION"),
                Email = dataRow.Field<string>("EMAIL")
            }).ToList();
            conexion.Close();
            return resultado;
        }

        public Clientes seleccionarCliente(int id)
        {

            conexion.Open();
            List<Clientes> resultado;
            SqlCommand cmdSQL = new SqlCommand("SELECT * FROM Clientes where id=" + id.ToString(), conexion);
            SqlDataAdapter daSQL = new SqlDataAdapter(cmdSQL);

            DataSet ds = new DataSet();
            daSQL.Fill(ds);
            resultado = ds.Tables[0].AsEnumerable()
            .Select(dataRow => new Clientes
            {
                NIF = dataRow.Field<string>("NIF"),
                Id = dataRow.Field<int>("ID"),
                Nombre = dataRow.Field<string>("NOMBRE"),
                Apellidos = dataRow.Field<string>("APELLIDOS"),
                Telefono = dataRow.Field<string>("TELEFONO"),
                Direccion = dataRow.Field<string>("DIRECCION"),
                Email = dataRow.Field<string>("EMAIL")
            }).ToList();
            conexion.Close();
            return resultado.First();
        }

        public int actualizarCliente(Clientes cliente)
        {
            conexion.Open();
            SqlCommand cmdSQL = new SqlCommand("UPDATE Clientes SET NIF=@nif,nombre=@nombre,apellidos=@apellidos,telefono=@telefono,direccion=@direccion,email=@email where id=@id", conexion);
            cmdSQL.Parameters.AddWithValue("@nombre", cliente.Nombre);
            cmdSQL.Parameters.AddWithValue("@nif", cliente.NIF);
            cmdSQL.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
            cmdSQL.Parameters.AddWithValue("@telefono", cliente.Telefono);
            cmdSQL.Parameters.AddWithValue("@id", cliente.Id);
            cmdSQL.Parameters.AddWithValue("@direccion", cliente.Email);
            cmdSQL.Parameters.AddWithValue("@email", cliente.Email);

            int filas = cmdSQL.ExecuteNonQuery();
            return filas;
        }

        public int insertarCliente(Clientes cliente)
        {
            conexion.Open();
            SqlCommand cmdSQL = new SqlCommand("INSERT INTO Clientes VALUES(@nif,@nombre,@apellidos,@telefono,@direccion,@email)", conexion);
            cmdSQL.Parameters.AddWithValue("@nombre", cliente.Nombre);
            cmdSQL.Parameters.AddWithValue("@nif", cliente.NIF);
            cmdSQL.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
            cmdSQL.Parameters.AddWithValue("@telefono", cliente.Telefono);
            cmdSQL.Parameters.AddWithValue("@direccion", cliente.Email);
            cmdSQL.Parameters.AddWithValue("@email", cliente.Email);

            int filas = cmdSQL.ExecuteNonQuery();
            return filas;
        }
        #endregion

        #region Empleados

        internal Empleados seleccionarEmpleado(int id)
        {
            conexion.Open();
            List<Empleados> resultado;
            SqlCommand cmdSQL = new SqlCommand("SELECT * FROM Empleados where id=" + id.ToString(), conexion);
            SqlDataAdapter daSQL = new SqlDataAdapter(cmdSQL);

            DataSet ds = new DataSet();
            daSQL.Fill(ds);
            resultado = ds.Tables[0].AsEnumerable()
            .Select(dataRow => new Empleados
            {
                NIF1 = dataRow.Field<string>("NIF"),
                Id = dataRow.Field<int>("ID"),
                Nombre = dataRow.Field<string>("NOMBRE"),
                Apellidos = dataRow.Field<string>("APELLIDOS"),
                Telefono = dataRow.Field<string>("TELEFONO"),
                Direccion = dataRow.Field<string>("DIRECCION"),
                Email = dataRow.Field<string>("EMAIL")
            }).ToList();
            conexion.Close();
            return resultado.First();
        }

        internal int insertarEmpleado(Empleados empleado)
        {
            conexion.Open();
            SqlCommand cmdSQL = new SqlCommand("INSERT INTO Empleados VALUES(@nif,@nombre,@apellidos,@telefono,@direccion,@email)", conexion);
            cmdSQL.Parameters.AddWithValue("@nombre", empleado.Nombre);
            cmdSQL.Parameters.AddWithValue("@nif", empleado.NIF1);
            cmdSQL.Parameters.AddWithValue("@apellidos", empleado.Apellidos);
            cmdSQL.Parameters.AddWithValue("@telefono", empleado.Telefono);
            cmdSQL.Parameters.AddWithValue("@direccion", empleado.Email);
            cmdSQL.Parameters.AddWithValue("@email", empleado.Email);

            int filas = cmdSQL.ExecuteNonQuery();
            return filas;
        }

        internal int actualizarEmpleado(Empleados empleado)
        {
            conexion.Open();
            SqlCommand cmdSQL = new SqlCommand("UPDATE Empleados SET NIF=@nif,nombre=@nombre,apellidos=@apellidos,telefono=@telefono,direccion=@direccion,email=@email where id=@id", conexion);
            cmdSQL.Parameters.AddWithValue("@nombre", empleado.Nombre);
            cmdSQL.Parameters.AddWithValue("@nif", empleado.NIF1);
            cmdSQL.Parameters.AddWithValue("@apellidos", empleado.Apellidos);
            cmdSQL.Parameters.AddWithValue("@telefono", empleado.Telefono);
            cmdSQL.Parameters.AddWithValue("@id", empleado.Id);
            cmdSQL.Parameters.AddWithValue("@direccion", empleado.Email);
            cmdSQL.Parameters.AddWithValue("@email", empleado.Email);

            int filas = cmdSQL.ExecuteNonQuery();
            return filas;
        }

        internal List<Empleados> seleccionarTodosEmpleados()
        {
            conexion.Open();
            List<Empleados> resultado;
            SqlCommand cmdSQL = new SqlCommand("SELECT * FROM Empleados", conexion);
            SqlDataAdapter daSQL = new SqlDataAdapter(cmdSQL);

            DataSet ds = new DataSet();
            daSQL.Fill(ds);
            resultado = ds.Tables[0].AsEnumerable()
            .Select(dataRow => new Empleados
            {
                NIF1 = dataRow.Field<string>("NIF"),
                Id = dataRow.Field<int>("ID"),
                Nombre = dataRow.Field<string>("NOMBRE"),
                Apellidos = dataRow.Field<string>("APELLIDOS"),
                Telefono = dataRow.Field<string>("TELEFONO"),
                Direccion = dataRow.Field<string>("DIRECCION"),
                Email = dataRow.Field<string>("EMAIL")
            }).ToList();
            conexion.Close();
            return resultado;
        }
        #endregion

        #region Vehiculos
        internal int actualizarVehiculo(Vehiculos vehiculo)
        {
            conexion.Open();
            SqlCommand cmdSQL = new SqlCommand("UPDATE Vehiculo SET modelo=@modelo,marca=@marca,npuertas=@npuertas,km=@km,tipo=@tipo,garantia=@garantia,fotografia=@fotografia,@color=color where id=@id", conexion);
            cmdSQL.Parameters.AddWithValue("@marca", vehiculo.Marca);
            cmdSQL.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
            cmdSQL.Parameters.AddWithValue("@npuertas", vehiculo.N_puertas);
            cmdSQL.Parameters.AddWithValue("@km", vehiculo.Km);
            cmdSQL.Parameters.AddWithValue("@tipo", vehiculo.Tipo_vehiculo);
            cmdSQL.Parameters.AddWithValue("@garantia", vehiculo.Garantia);
            cmdSQL.Parameters.AddWithValue("@fotografia", vehiculo.Fotografia);
            cmdSQL.Parameters.AddWithValue("@color", vehiculo.Color);
            cmdSQL.Parameters.AddWithValue("@id", vehiculo.Id);

            int filas = cmdSQL.ExecuteNonQuery();
            return filas;
        }
        public Vehiculos seleccionarVehiculo(int id)
        {

            conexion.Open();
            List<Vehiculos> resultado;
            SqlCommand cmdSQL = new SqlCommand("SELECT * FROM Vehiculo where id=" + id.ToString(), conexion);
            SqlDataAdapter daSQL = new SqlDataAdapter(cmdSQL);

            DataSet ds = new DataSet();
            daSQL.Fill(ds);
            resultado = ds.Tables[0].AsEnumerable()
            .Select(dataRow => new Vehiculos
            {
                Color = dataRow.Field<string>("Color"),
                Id = dataRow.Field<int>("ID"),
                Marca = dataRow.Field<string>("MARCA"),
                Modelo = dataRow.Field<string>("MODELO"),
                Garantia = dataRow.Field<int>("GARANTIA"),
                Km = int.Parse(dataRow.Field<string>("KM")),
                N_puertas = dataRow.Field<int>("NPUERTAS"),
                Fotografia = dataRow.Field<string>("FOTOGRAFIA"),
                Tipo_vehiculo = (Tipo_Vehiculo)Enum.Parse(typeof(Tipo_Vehiculo), dataRow.Field<string>("TIPO")),
            }).ToList();
            conexion.Close();
            return resultado.First();
        }
        internal List<Vehiculos> seleccionarTodosVehiculos()
        {
            conexion.Open();
            List<Vehiculos> resultado;
            SqlCommand cmdSQL = new SqlCommand("SELECT * FROM Vehiculo", conexion);
            SqlDataAdapter daSQL = new SqlDataAdapter(cmdSQL);

            DataSet ds = new DataSet();
            daSQL.Fill(ds);
            resultado = ds.Tables[0].AsEnumerable()
            .Select(dataRow => new Vehiculos
            {
                Color = dataRow.Field<string>("Color"),
                Id = dataRow.Field<int>("ID"),
                Marca = dataRow.Field<string>("MARCA"),
                Modelo = dataRow.Field<string>("MODELO"),
                Garantia = dataRow.Field<int>("GARANTIA"),
                Km = int.Parse(dataRow.Field<string>("KM")),
                N_puertas = dataRow.Field<int>("NPUERTAS"),
                Fotografia = dataRow.Field<string>("FOTOGRAFIA"),
                Tipo_vehiculo = (Tipo_Vehiculo)Enum.Parse(typeof(Tipo_Vehiculo), dataRow.Field<string>("TIPO")),

            }).ToList();
            conexion.Close();
            return resultado;
        }
        #endregion



        public int insertarCompraVenta(CompraVenta compaventa)
        {
            conexion.Open();
            SqlCommand cmdSQL = new SqlCommand("INSERT INTO CompraVenta VALUES(@fecha,@precio,@tipo,@cliente,@empleado)", conexion);
            cmdSQL.Parameters.AddWithValue("@cliente", compaventa.Cliente);
            cmdSQL.Parameters.AddWithValue("@empleado", compaventa.Empleado);
            cmdSQL.Parameters.AddWithValue("@fecha", compaventa.Fecha);
            cmdSQL.Parameters.AddWithValue("@precio", compaventa.Precio);
            cmdSQL.Parameters.AddWithValue("@tipo", compaventa.Tipo.ToString());

            int filas = cmdSQL.ExecuteNonQuery();
            return filas;
        }

        public List<CompraVenta> seleccionarCompraVenta()
        {

            conexion.Open();
            List<CompraVenta> resultado;
            SqlCommand cmdSQL = new SqlCommand("SELECT * FROM CompraVenta", conexion);
            SqlDataAdapter daSQL = new SqlDataAdapter(cmdSQL);

            DataSet ds = new DataSet();
            daSQL.Fill(ds);
            resultado = ds.Tables[0].AsEnumerable()
            .Select(dataRow => new CompraVenta
            {
                Fecha = dataRow.Field<DateTime>("fecha"),
                Id = dataRow.Field<int>("ID_CompraVenta"),
                Precio = dataRow.Field<float>("precio"),
                Empleado = dataRow.Field<int>("ID_EMPLEADO"),
                Cliente = dataRow.Field<int>("ID_CLIENTE"),
                Tipo = (Tipo)Enum.Parse(typeof(Tipo), dataRow.Field<string>("TIPO")),
                
            }).ToList();
            conexion.Close();
            return resultado;
        }
    }
}