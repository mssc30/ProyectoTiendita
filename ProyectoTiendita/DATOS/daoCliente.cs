using MySql.Data.MySqlClient;
using ProyectoTiendita.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTiendita.DATOS
{
    public class daoCliente
    {
        String conexion = "server=remotemysql.com; database=OhfuHemABZ; user=OhfuHemABZ; pwd=Fo9zYFclIV";
        public List<Cliente> obtenerTodos()
        {
            ///CREAR CONEXION, MODIFICARLA, USARLA
            List<Cliente> clientes = new List<Cliente>();
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "SELECT * FROM CLIENTES";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                MySqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Cliente cliente = new Cliente
                    (
                        dr.GetString("NOMBRE"),
                        dr.GetString("APELLIDO"),
                        dr.GetString("DIRECCION"),
                        dr.GetString("TELEFONO"),
                        dr.GetString("EMAIL"),
                        dr.GetString("CONTRASENIA")
                    );

                    //Console.WriteLine(user.Nombre);

                    clientes.Add(cliente);
                }

                comando.Dispose();
                return clientes;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                ///CERRAR CONEXION
                cn.Close();
                cn.Dispose();
            }

        }

        public Cliente obtenerUno(String idCliente)
        {
            ///CREAR CONEXION, MODIFICARLA, USARLA
            MySqlConnection cn = new MySqlConnection();
            try
            {
                Cliente cliente = null;
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "SELECT * FROM CLIENTES WHERE EMAIL = @EMAIL";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("EMAIL", idCliente);
                MySqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    cliente = new Cliente
                    (
                        dr.GetString("NOMBRE"),
                        dr.GetString("APELLIDO"),
                        dr.GetString("DIRECCION"),
                        dr.GetString("TELEFONO"),
                        dr.GetString("EMAIL"), 
                        dr.GetString("CONTRASENIA")
                    );

                    //Console.WriteLine(user.Nombre);
                }

                comando.Dispose();
                return cliente;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                ///CERRAR CONEXION
                cn.Close();
                cn.Dispose();
            }

        }

        public Boolean agregar(Cliente cliente)
        {
            ///CREAR, MODIFICAR Y USAR LA CONEXION
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "INSERT INTO CLIENTES (NOMBRE, APELLIDO, DIRECCION, TELEFONO, EMAIL, CONTRASENIA)" +
                    "VALUES (@NOMBRE, @APELLIDO, @DIRECCION, @TELEFONO, @EMAIL, @CONTRASENIA)";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("NOMBRE", cliente.nombre);
                comando.Parameters.AddWithValue("APELLIDO", cliente.apellidos);
                comando.Parameters.AddWithValue("DIRECCION", cliente.direccion);
                comando.Parameters.AddWithValue("TELEFONO", cliente.telefono);
                comando.Parameters.AddWithValue("EMAIL", cliente.email);
                comando.Parameters.AddWithValue("CONTRASENIA", cliente.contrasena);
                comando.ExecuteNonQuery();
                comando.Dispose();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                ///CERRAR TODO
                cn.Close();
                cn.Dispose();
            }
        }

        public Boolean modificarCliente(Cliente user)
        {
            ///CREAR, MODIFICAR, USAR LA CONEXION
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "UPDATE CLIENTES SET NOMBRE = @NOMBRE, " +
                    "APELLIDO = @APELLIDO, DIRECCION = @DIRECCION, TELEFONO = @TELEFONO, CONTRASENIA = @CONTRA " +
                    "WHERE EMAIL = @EMAIL";

                MySqlCommand comando = new MySqlCommand(strSQL, cn);

                comando.Parameters.AddWithValue("NOMBRE", user.nombre);
                comando.Parameters.AddWithValue("APELLIDO", user.apellidos);
                comando.Parameters.AddWithValue("DIRECCION", user.direccion);
                comando.Parameters.AddWithValue("TELEFONO", user.telefono);
                comando.Parameters.AddWithValue("CONTRA", user.contrasena);
                comando.Parameters.AddWithValue("EMAIL", user.email);
                comando.ExecuteNonQuery();
                comando.Dispose();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                ///CERRAR TODO
                cn.Close();
                cn.Dispose();
            }
        }

        public Boolean eliminarCliente(String clienteID)
        {
            ///CREAR, MODIFICAR LA CONEXION 
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "DELETE FROM CLIENTES WHERE EMAIL = @ID";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("@ID", clienteID);
                comando.ExecuteNonQuery();
                comando.Dispose();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                ///CERRAR TODO
                cn.Close();
                cn.Dispose();
            }
        }

        public Boolean autenticar(String user, String contra)
        {
            ///CREAR, MODIFICAR LA CONEXION 
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "SELECT * FROM CLIENTES WHERE EMAIL = @EMAIL AND CONTRASENIA = @PASS";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("@EMAIL", user);
                comando.Parameters.AddWithValue("@PASS", contra);
                MySqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    return true;
                    //Console.WriteLine(user.Nombre);
                }

                comando.Dispose();
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                ///CERRAR TODO
                cn.Close();
                cn.Dispose();
            }
        }
    }
}
