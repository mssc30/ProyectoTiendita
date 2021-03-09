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
        //CADENA DE CONEXION A LA BASE DE DATOS EN LA NUBE
        String conexion = "server=remotemysql.com; database=OhfuHemABZ; user=OhfuHemABZ; pwd=Fo9zYFclIV";
        
        /// <summary>
        /// EL METODO OBTENER TODOS SE USA PARA REALIZAR UNA CONSULTA A LA BASE DE DATOS 
        /// EN LA NUBE
        /// </summary>
        /// <returns>RETORNA UNA LISTA CON LOS PEDIDOS QUE ESTEN REGISTRADOS EN LA BD</returns>
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
                        dr.GetString("EMAIL_CLIENTE"),
                        dr.GetDouble("PRECIO_TOTAL"),
                        dr.GetString("CLAVE_PEDIDO")
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

        /// <summary>
        /// METODO PARA AGREGAR A LA BASE DE DATOS UN PEDIDO CON SUS RESPECTIVOS DETALLES
        /// </summary>
        /// <param name="pedido">OBJETO TIPO PEDIDO QUE REPRESENTA EL NUEVO PEDIDO QUE SE VA A AGREGAR</param>
        /// <param name="detalles">LISTA DE DETALLES CORRESPONDIENTES AL PEDIDO</param>
        /// <returns>VALOR BOLEANO QUE REPRESENTA SI SE AGREGO O NO</returns>
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
                string strSQL = "INSERT INTO PEDIDOS (EMAIL_CLIENTE, PRECIO_TOTAL, CLAVE_PEDIDO)" +
                    "VALUES (@EMAIL_CLIENTE, @PRECIO_TOTAL, @CLAVE_PEDIDO)";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("EMAIL_CLIENTE", pedido.emailCliente);
                comando.Parameters.AddWithValue("PRECIO_TOTAL", pedido.precioTotal);
                comando.Parameters.AddWithValue("CLAVE_PEDIDO", pedido.clave);
                comando.ExecuteNonQuery();
                comando.Dispose();

                foreach(DetallePedido detalle in detalles){
                    ///EJECUTAR COMANDO
                    string strSQL2 = "INSERT INTO DETALLE_DE_PEDIDOS (CLAVE_PEDIDO, ID_PRODUCTO, CANTIDAD)" +
                        "VALUES (@CLAVE_PEDIDO, @ID_PRODUCTO, @CANTIDAD)";
                    MySqlCommand comando2 = new MySqlCommand(strSQL2, cn);
                    comando2.Parameters.AddWithValue("CLAVE_PEDIDO", detalle.numPedido);
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