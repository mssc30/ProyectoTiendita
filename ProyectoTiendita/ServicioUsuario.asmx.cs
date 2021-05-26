using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ProyectoTiendita.DATOS;
using ProyectoTiendita.POJOS;


namespace ProyectoTiendita
{
    /// <summary>
    /// Descripción breve de ServicioUsuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioUsuario : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Usuario> ObtenerTodos()
        {
            return new daoUsuario().obtenerTodos();
        }

        [WebMethod]
        public Usuario ObtenerUno(String idUser)
        {
            daoUsuario dao = new daoUsuario();
            return dao.obtenerUno(idUser);
        }

        [WebMethod]
        public bool AgregarUsuario(Usuario prod)
        {
            daoUsuario dao = new daoUsuario();
            return dao.agregar(prod);
        }

        [WebMethod]
        public bool ModificarUsuario(Usuario prod)
        {
            daoUsuario dao = new daoUsuario();
            return dao.modificarUsuario(prod);
        }

        [WebMethod]
        public bool EliminarUsuario(String idUser)
        {
            daoUsuario dao = new daoUsuario();
            return dao.eliminarUsuario(idUser);
        }
    }
}
