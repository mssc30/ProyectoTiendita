using MySql.Data.MySqlClient;
using ProyectoTiendita.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTiendita.DATOS
{
    public class daoUsuario
    {
        String conexion = "server=remotemysql.com; database=OhfuHemABZ; user=OhfuHemABZ; pwd=Fo9zYFclIV";
        public List<Usuario> obtenerTodos()
        {
            ///CREAR CONEXION, MODIFICARLA, USARLA
            List<Usuario> usuarios = new List<Usuario>();
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "SELECT * FROM USUARIOS";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                MySqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Usuario user = new Usuario
                    (
                        dr.GetString("USUARIO"),
                        dr.GetString("CONTRASENIA"),
                        dr.GetString("NOMBRE"),
                        dr.GetString("APELLIDOS"),
                        dr.GetString("TELEFONO")
                    );

                    //Console.WriteLine(user.Nombre);

                    usuarios.Add(user);
                }

                comando.Dispose();
                return usuarios;
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

        public Usuario obtenerUno(String idUser)
        {
            ///CREAR CONEXION, MODIFICARLA, USARLA
            MySqlConnection cn = new MySqlConnection();
            try
            {
                Usuario user = null;
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "SELECT * FROM USUARIOS WHERE USUARIO = @USUARIO";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("USUARIO", idUser);
                MySqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {

                    user = new Usuario
                    (
                        dr.GetString("USUARIO"),
                        dr.GetString("CONTRASENIA"),
                        dr.GetString("NOMBRE"),
                        dr.GetString("APELLIDOS"),
                        dr.GetString("TELEFONO")
                    );

                    //Console.WriteLine(user.Nombre);
                }

                comando.Dispose();
                return user;
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

        public Boolean agregar(Usuario usuario)
        {
            ///CREAR, MODIFICAR Y USAR LA CONEXION
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "INSERT INTO USUARIOS (USUARIO, CONTRASENIA, NOMBRE, APELLIDOS, TELEFONO)" +
                    "VALUES (@USUARIO, @CONTRASENIA, @NOMBRE, @APELLIDOS, @TELEFONO)";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("USUARIO", usuario.usuario);
                comando.Parameters.AddWithValue("CONTRASENIA", usuario.contrasena);
                comando.Parameters.AddWithValue("NOMBRE", usuario.nombre);
                comando.Parameters.AddWithValue("APELLIDOS", usuario.apellidos);
                comando.Parameters.AddWithValue("TELEFONO", usuario.telefono);
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

        public Boolean modificarUsuario(Usuario user)
        {
            ///CREAR, MODIFICAR, USAR LA CONEXION
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "UPDATE USUARIOS SET CONTRASENIA = @CONTRASENIA, " +
                    "NOMBRE = @NOMBRE, APELLIDOS = @APELLIDOS, TELEFONO = @TELEFONO " +
                    "WHERE USUARIO = @USUARIO";

                MySqlCommand comando = new MySqlCommand(strSQL, cn);

                comando.Parameters.AddWithValue("CONTRASENIA", user.contrasena);
                comando.Parameters.AddWithValue("NOMBRE", user.nombre);
                comando.Parameters.AddWithValue("APELLIDOS", user.apellidos);
                comando.Parameters.AddWithValue("TELEFONO", user.telefono);
                comando.Parameters.AddWithValue("USUARIO", user.usuario);
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

        public Boolean eliminarUsuario(String usuarioID)
        {
            ///CREAR, MODIFICAR LA CONEXION 
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = conexion;
                cn.Open();
                ///EJECUTAR COMANDO
                string strSQL = "DELETE FROM USUARIOS WHERE USUARIO = @ID";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("@ID", usuarioID);
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
                string strSQL = "SELECT * FROM USUARIOS WHERE USUARIO = @USER AND CONTRASENIA = @PASS";
                MySqlCommand comando = new MySqlCommand(strSQL, cn);
                comando.Parameters.AddWithValue("@USER", user);
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
