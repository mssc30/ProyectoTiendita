using MySql.Data.MySqlClient;
using ProyectoTiendita.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTiendita.DATOS
{
    public class daoProducto
    {
        String conexion = "server=remotemysql.com; database=OhfuHemABZ; user=OhfuHemABZ; pwd=Fo9zYFclIV";
        public List<Producto> obtenerTodos()
        {
            ///CREAR CONEXION, MODIFICARLA, USARLA
            List<Producto> productos = new List<Producto>();
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "SELECT * FROM PRODUCTOS";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                MySqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Producto producto = new Producto
                    (
                        dr.GetInt32("ID_PRODUCTO"),
                        dr.GetString("NOMBRE"),
                        dr.GetDouble("PRECIO"),
                        dr.GetInt32("ESTADO"),
                        dr.GetString("FOTO")
                    );

                    productos.Add(producto);
                }

                comando.Dispose();
                return productos;
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

        public Producto obtenerUno(int idProducto)
        {
            ///CREAR CONEXION, MODIFICARLA, USARLA
            MySqlConnection cn = new MySqlConnection();
            try
            {
                Producto producto = null;
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "SELECT * FROM PRODUCTOS WHERE ID_PRODUCTO = @ID";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("ID", idProducto);
                MySqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    producto = new Producto
                    (
                        dr.GetInt32("ID_PRODUCTO"),
                        dr.GetString("NOMBRE"),
                        dr.GetDouble("PRECIO"),
                        dr.GetInt32("ESTADO"),
                        dr.GetString("FOTO")
                    );

                }

                comando.Dispose();
                return producto;
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

        public Boolean agregar(Producto producto)
        {
            ///CREAR, MODIFICAR Y USAR LA CONEXION
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "INSERT INTO PRODUCTOS (NOMBRE, PRECIO, ESTADO, FOTO)" +
                    "VALUES (@NOMBRE, @PRECIO, @ESTADO, @FOTO)";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("NOMBRE", producto.nombre);
                comando.Parameters.AddWithValue("PRECIO", producto.precio);
                comando.Parameters.AddWithValue("ESTADO", producto.estado);
                comando.Parameters.AddWithValue("FOTO", producto.foto);
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

        public Boolean modificarProducto(Producto producto)
        {
            ///CREAR, MODIFICAR, USAR LA CONEXION
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "UPDATE PRODUCTOS SET NOMBRE = @NOMBRE, " +
                    "PRECIO = @PRECIO, ESTADO = @ESTADO, FOTO = @FOTO " +
                    "WHERE ID_PRODUCTO = @ID";

                MySqlCommand comando = new MySqlCommand(strSQL, cn);

                comando.Parameters.AddWithValue("NOMBRE", producto.nombre);
                comando.Parameters.AddWithValue("PRECIO", producto.precio);
                comando.Parameters.AddWithValue("ESTADO", producto.estado);
                comando.Parameters.AddWithValue("FOTO", producto.foto);
                comando.Parameters.AddWithValue("ID", producto.idProducto);
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

        public Boolean eliminarProducto(int productoID)
        {
            ///CREAR, MODIFICAR LA CONEXION 
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "DELETE FROM PRODUCTOS WHERE ID_PRODUCTO = @ID";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("@ID", productoID);
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

    }
}