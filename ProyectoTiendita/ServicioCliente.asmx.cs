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
    /// Descripción breve de ServicioCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioCliente : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Cliente> ObtenerTodos()
        {
            return new daoCliente().obtenerTodos();
        }

        [WebMethod]
        public Cliente ObtenerUno(String idCliente)
        {
            daoCliente dao = new daoCliente();
            return dao.obtenerUno(idCliente);
        }

        [WebMethod]
        public bool AgregarCliente(Cliente prod)
        {
            daoCliente dao = new daoCliente();
            return dao.agregar(prod);
        }

        [WebMethod]
        public bool ModificarCliente(Cliente prod)
        {
            daoCliente dao = new daoCliente();
            return dao.modificarCliente(prod);
        }

        [WebMethod]
        public bool EliminarCliente(String idCliente)
        {
            daoCliente dao = new daoCliente();
            return dao.eliminarCliente(idCliente);
        }
    }
}
