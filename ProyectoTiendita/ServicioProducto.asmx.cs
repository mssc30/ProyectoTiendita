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
    /// Descripción breve de ServicioProducto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioProducto : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public List<Producto> ObtenerTodos()
        {
            return new daoProducto().obtenerTodos();
        }

        [WebMethod]
        public Producto ObtenerUno(int idProd)
        {
            daoProducto dao = new daoProducto();
            return dao.obtenerUno(idProd);
        }

        [WebMethod]
        public bool AgregarProducto(Producto prod)
        {
            daoProducto dao = new daoProducto();
            return dao.agregar(prod);
        }

        [WebMethod]
        public bool ModificarProducto(Producto prod)
        {
            daoProducto dao = new daoProducto();
            return dao.modificarProducto(prod);
        }

        [WebMethod]
        public bool EliminarProducto(int idProd)
        {
            daoProducto dao = new daoProducto();
            return dao.eliminarProducto(idProd);
        }
    }
}
