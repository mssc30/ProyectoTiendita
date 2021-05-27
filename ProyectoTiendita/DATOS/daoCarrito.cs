using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoTiendita.POJOS;
using MySql.Data.MySqlClient;

namespace ProyectoTiendita.DATOS
{
    
    public class daoCarrito
    {
        String conexion = "server=remotemysql.com; database=OhfuHemABZ; user=OhfuHemABZ; pwd=Fo9zYFclIV";
        public List<Carrito> obtenerTodos(String idCliente)
        {
            ///CREAR CONEXION, MODIFICARLA, USARLA
            List<Carrito> elcarrito = new List<Carrito>();
            MySqlConnection cn = new MySqlConnection();
            daoprod = new daoProducto();
            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "SELECT * FROM CARRITO WHERE ID_CLIENTE=@ID_CLIENTE";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("ID_CLIENTE", idCliente);
                MySqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Carrito car = new Carrito
                    (
                        dr.GetString("ID_CLIENTE"),
                        dr.GetInt32("ID_PRODUCTO"),
                        daoprod.obtenerUno(dr.GetInt32("ID_PRODUCTO")).nombre,
                        dr.GetInt32("CANTIDAD"),
                        dr.GetDouble("SUBTOTAL")
                    );

                    elcarrito.Add(car);
                }

                comando.Dispose();
                return elcarrito;
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
        daoProducto daoprod;
        public Carrito obtenerUno(int idProducto)
        {
            ///CREAR CONEXION, MODIFICARLA, USARLA
            MySqlConnection cn = new MySqlConnection();
            try
            {
                daoprod = new daoProducto();
                Carrito carrito = null;
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "SELECT * FROM CARRITO WHERE ID_PRODUCTO = @ID";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("ID", idProducto);
                MySqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    
                    carrito = new Carrito();
                    carrito.idCliente=dr.GetString("ID_CLIENTE");
                    carrito.idProducto=dr.GetInt32("ID_PRODUCTO");
                    carrito.nombreProducto = daoprod.obtenerUno(dr.GetInt32("ID_PRODUCTO")).nombre;
                    carrito.cantidad=dr.GetInt32("CANTIDAD");
                    carrito.subtotal= (daoprod.obtenerUno(dr.GetInt32("ID_PRODUCTO")).precio)*dr.GetInt32("CANTIDAD");
                }

                comando.Dispose();
                return carrito;
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

        public Boolean agregar(int idProducto,double precio, String idCliente)
        {
            ///CREAR, MODIFICAR Y USAR LA CONEXION
            MySqlConnection cn = new MySqlConnection();
            try
            {
                Carrito estaAgregado = obtenerUno(idProducto);
                if (estaAgregado== null)
                {
                    cn.ConnectionString = conexion;
                    cn.Open();
                    ///EJECUTAR COMANDO

                    string strSQL = "INSERT INTO CARRITO (ID_CLIENTE, ID_PRODUCTO, CANTIDAD, SUBTOTAL)" +
                        "VALUES (@ID_CLIENTE, @ID_PRODUCTO, @CANTIDAD, @SUBTOTAL)";
                    MySqlCommand comando = new MySqlCommand(strSQL, cn);
                    comando.Parameters.AddWithValue("ID_CLIENTE", idCliente);
                    comando.Parameters.AddWithValue("ID_PRODUCTO", idProducto);
                    comando.Parameters.AddWithValue("CANTIDAD", 1);
                    comando.Parameters.AddWithValue("SUBTOTAL", precio);
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    return true;
                }
                else {
                    cn.ConnectionString = conexion;
                    cn.Open();
                    ///EJECUTAR COMANDO

                    string strSQL = "UPDATE CARRITO SET CANTIDAD = @CANTIDAD, SUBTOTAL=@SUBTOTAL WHERE ID_CLIENTE=@ID_CLIENTE AND ID_PRODUCTO = @ID_PRODUCTO";
                    MySqlCommand comando = new MySqlCommand(strSQL, cn);
                    comando.Parameters.AddWithValue("CANTIDAD", estaAgregado.cantidad+1);
                    comando.Parameters.AddWithValue("SUBTOTAL", estaAgregado.subtotal+precio);
                    comando.Parameters.AddWithValue("ID_CLIENTE", idCliente);
                    comando.Parameters.AddWithValue("ID_PRODUCTO", idProducto);
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    return true;
                }
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

        public Boolean eliminarCarrito(String idCliente)
        {

            ///CREAR, MODIFICAR LA CONEXION 
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "DELETE FROM CARRITO WHERE ID_CLIENTE = @ID";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("@ID", idCliente);
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

        public bool agregarAdmin(List<Carrito> elcarrito, String ID)
        {
            ///CREAR, MODIFICAR Y USAR LA CONEXION
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "INSERT INTO PEDIDOS_PENDIENTES (ID, ID_CLIENTE, DIRECCION, PEDIDO, TOTAL, ESTADO)" +
                    "VALUES (@ID, @ID_CLIENTE, @DIRECCION, @PEDIDO, @TOTAL, @ESTADO)";

                String pedido = "";
                double total = 0.0;

                foreach(Carrito x in elcarrito)
                {
                    pedido += x.cantidad + "-" + x.nombreProducto + "\n";
                    total += x.subtotal;
                }

                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("ID", ID);
                comando.Parameters.AddWithValue("ID_CLIENTE", elcarrito[0].idCliente);
                comando.Parameters.AddWithValue("DIRECCION", new daoCliente().obtenerUno(elcarrito[0].idCliente).direccion);
                comando.Parameters.AddWithValue("PEDIDO", pedido);
                comando.Parameters.AddWithValue("TOTAL", total);
                comando.Parameters.AddWithValue("ESTADO", "PENDIENTE");
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
        public List<pedidoAdmin> obtenerTodosAdmin(String estado)
        {
            ///CREAR CONEXION, MODIFICARLA, USARLA
            List<pedidoAdmin> pendientes = new List<pedidoAdmin>();
            MySqlConnection cn = new MySqlConnection();
            daoprod = new daoProducto();
            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "SELECT * FROM PEDIDOS_PENDIENTES WHERE ESTADO=@ESTADO";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("ESTADO",estado);
                MySqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    pedidoAdmin ped = new pedidoAdmin();
                    ped.ID = dr.GetString("ID");
                    ped.ID_CLIENTE = dr.GetString("ID_CLIENTE");
                    ped.DIRECCION = dr.GetString("DIRECCION");
                    ped.PEDIDO = dr.GetString("PEDIDO");
                    ped.TOTAL = dr.GetDouble("TOTAL");
                    ped.ESTADO = dr.GetString("ESTADO");
                    pendientes.Add(ped);
                }

                comando.Dispose();
                return pendientes;
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
        public Boolean eliminarPendiente(String ID)
        {

            ///CREAR, MODIFICAR LA CONEXION 
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "UPDATE PEDIDOS_PENDIENTES SET ESTADO=@ESTADO WHERE ID = @ID";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("@ID", ID);
                comando.Parameters.AddWithValue("ESTADO", "ENTREGADO");
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