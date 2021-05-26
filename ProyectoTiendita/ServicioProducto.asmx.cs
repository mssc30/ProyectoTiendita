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
    /// El servicio tiene la funcion de usar el daoProducto con todas las funcionalidades que este provee,
    /// Realizar consultas a la base de datos y permite agregar, modificar y eliminar un producto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class ServicioProducto : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        /// <summary>
        /// El metodo ObtenerTodos lo que hace es hacer uso del daoProducto para realizar una consulta
        /// a la base de datos de todos los productos que esten registrados.
        /// </summary>
        /// <returns>Este retorna una lista con objetos de tipo productos</returns>
        [WebMethod]
        public List<Producto> ObtenerTodos()
        {
            return new daoProducto().obtenerTodos();
        }

        /// <summary>
        /// Metodo ObtenerUno, su fin es por medio del daoProducto realizar una busqueda de un producto en la base de datos y
        /// regresar su informacion si este es encontrado.
        /// </summary>
        /// <param name="idProd">Representa la clave por la cual se va a buscar el producto</param>
        /// <returns>Retorna un objeto de tipo producto, con la informacion que contiene</returns>
        [WebMethod]
        public Producto ObtenerUno(int idProd)
        {
            daoProducto dao = new daoProducto();
            return dao.obtenerUno(idProd);
        }

        /// <summary>
        /// La funcion del metodo AgregarProducto es usando la clase daoProducto agregar un nuevo producto
        /// a la base de datos para esto recibe un objeto de tipo producto
        /// </summary>
        /// <param name="prod">Este representa el objeto de tipo producto con todos sus atributos</param>
        /// <returns>Retorna un valor booleano para identificar si el producto fue agregado de manera correcta</returns>
        [WebMethod]
        public bool AgregarProducto(Producto prod)
        {
            daoProducto dao = new daoProducto();
            return dao.agregar(prod);
        }

        /// <summary>
        /// El metodo ModificarProducto esta implementado para que use el metodo de la clase daoProducto
        /// para ser capaz de modificar un producto, este producto a modificar es recibido en el metodo.
        /// </summary>
        /// <param name="prod">Objeto que representa al producto que se va a modificar</param>
        /// <returns>Retorna un valor booleano que significa si el producto fue modificado</returns>
        [WebMethod]
        public bool ModificarProducto(Producto prod)
        {
            daoProducto dao = new daoProducto();
            return dao.modificarProducto(prod);
        }

        /// <summary>
        /// EliminarProducto, este metodo tiene como funcion hacer uso del metodo que elimina de la 
        /// base de datos el producto que se le especifique por medio de su clave.
        /// </summary>
        /// <param name="idProd">Clave del producto que se va a eliminar</param>
        /// <returns>Retorna un valor booleano que significa si el producto fue eliminado</returns>
        [WebMethod]
        public bool EliminarProducto(int idProd)
        {
            daoProducto dao = new daoProducto();
            return dao.eliminarProducto(idProd);
        }
    }
}
