using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoTiendita.POJOS;
using MySql.Data.MySqlClient;


namespace ProyectoTiendita.DATOS
{
    public class daoPedido
    {
        String conexion = "server=remotemysql.com; database=OhfuHemABZ; user=OhfuHemABZ; pwd=Fo9zYFclIV";
        public List<Pedido> obtenerTodos()
        {
            ///CREAR CONEXION, MODIFICARLA, USARLA
            List<Pedido> pedidos = new List<Pedido>();
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "SELECT * FROM PEDIDOS";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                MySqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Pedido pedido = new Pedido
                    (
                        dr.GetInt32("NUM_PEDIDO"),
                        dr.GetString("EMAIL_CLIENTE"),
                        dr.GetDouble("PRECIO_TOTAL"),
                        dr.GetInt32("ESTADO_PEDIDO"),
                        dr.GetString("FECHA"),
                        dr.GetString("HORA")
                    );

                    pedidos.Add(pedido);
                }

                comando.Dispose();
                return pedidos;
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

        public List<Pedido> obtenerTodosCliente(String email)
        {
            ///CREAR CONEXION, MODIFICARLA, USARLA
            List<Pedido> pedidos = new List<Pedido>();
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "SELECT * FROM PEDIDOS WHERE EMAIL_CLIENTE=@EMAIL_CLIENTE";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("EMAIL_CLIENTE", email);
                MySqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Pedido pedido = new Pedido
                    (
                        dr.GetInt32("NUM_PEDIDO"),
                        dr.GetString("EMAIL_CLIENTE"),
                        dr.GetDouble("PRECIO_TOTAL"),
                        dr.GetInt32("ESTADO_PEDIDO"),
                        dr.GetString("FECHA"),
                        dr.GetString("HORA")
                    );

                    pedidos.Add(pedido);
                }

                comando.Dispose();
                return pedidos;
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

        public List<Pedido> obtenerTodosEstado(int estado)
        {
            ///CREAR CONEXION, MODIFICARLA, USARLA
            List<Pedido> pedidos = new List<Pedido>();
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "SELECT * FROM PEDIDOS WHERE ESTADO_PEDIDO=@ESTADO_PEDIDO";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("ESTADO_PEDIDO", estado);
                MySqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Pedido pedido = new Pedido
                    (
                        dr.GetInt32("NUM_PEDIDO"),
                        dr.GetString("EMAIL_CLIENTE"),
                        dr.GetDouble("PRECIO_TOTAL"),
                        dr.GetInt32("ESTADO_PEDIDO"),
                        dr.GetString("FECHA"),
                        dr.GetString("HORA")
                    );

                    pedidos.Add(pedido);
                }

                comando.Dispose();
                return pedidos;
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

        public Pedido obtenerUno(int idPedido)
        {
            ///CREAR CONEXION, MODIFICARLA, USARLA
            MySqlConnection cn = new MySqlConnection();
            try
            {
                Pedido pedido = null;
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "SELECT * FROM PEDIDOS WHERE NUM_PEDIDO = @NUM_PEDIDO";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("NUM_PEDIDO", idPedido);
                MySqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    pedido = new Pedido
                    (
                        dr.GetInt32("NUM_PEDIDO"),
                        dr.GetString("EMAIL_CLIENTE"),
                        dr.GetDouble("PRECIO_TOTAL"),
                        dr.GetInt32("ESTADO_PEDIDO"),
                        dr.GetString("FECHA"),
                        dr.GetString("HORA")
                    );

                }

                comando.Dispose();
                return pedido;
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

        public Boolean modificarPedido(Pedido pedido)
        {
            ///CREAR, MODIFICAR, USAR LA CONEXION
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "UPDATE PEDIDOS SET ESTADO_PEDIDO = @ESTADO_PEDIDO, " +
                    "WHERE NUM_PEDIDO = @NUM_PEDIDO";

                MySqlCommand comando = new MySqlCommand(strSQL, cn);

                comando.Parameters.AddWithValue("ESTADO_PEDIDO", pedido.estadoPedido);
                comando.Parameters.AddWithValue("NUM_PEDIDO", pedido.numPedido);
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

        public Boolean agregar(Pedido pedido, List<DetallePedido> detalles)
        {
            ///CREAR, MODIFICAR Y USAR LA CONEXION
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = conexion;
            cn.Open();
            //INICIA UN TRANSACCION
            MySqlTransaction mySqlTransaction = cn.BeginTransaction();
            try
            {

                ///EJECUTAR COMANDO
                string strSQL = "INSERT INTO PEDIDOS (EMAIL_CLIENTE, PRECIO_TOTAL, ESTADO_PEDIDO, FECHA, HORA)" +
                    "VALUES (@EMAIL_CLIENTE, @PRECIO_TOTAL, @ESTADO_PEDIOD, @FECHA, @HORA)";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("EMAIL_CLIENTE", pedido.emailCliente);
                comando.Parameters.AddWithValue("PRECIO_TOTAL", pedido.precioTotal);
                comando.Parameters.AddWithValue("ESTADO_PEDIDO", pedido.estadoPedido);
                comando.Parameters.AddWithValue("FECHA", pedido.fecha);
                comando.Parameters.AddWithValue("HORA", pedido.hora);
                comando.ExecuteNonQuery();
                comando.Dispose();

                foreach(DetallePedido detalle in detalles){
                    ///EJECUTAR COMANDO
                    string strSQL2 = "INSERT INTO DETALLE_DE_PEDIDOS (NUM_PEDIDO, ID_PRODUCTO, CANTIDAD)" +
                        "VALUES (@NUM_PEDIDO, @ID_PRODUCTO, @CANTIDAD)";
                    MySqlCommand comando2 = new MySqlCommand(strSQL2, cn);
                    comando2.Parameters.AddWithValue("NUM_PEDIDO", detalle.numPedido);
                    comando2.Parameters.AddWithValue("ID_PRODUCTO", detalle.idProducto);
                    comando2.Parameters.AddWithValue("CANTIDAD", detalle.cantidad);
                    comando2.ExecuteNonQuery();
                    comando2.Dispose();
                }
                mySqlTransaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                mySqlTransaction.Rollback();
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