using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTiendita.POJOS
{
    /// <summary>
    /// POJO QUE REPRESENTA UN OBJETO PRODUCTO CON SUS ATRIBUTOS
    /// TIENE CONSTRUCTORES 2 SOBRE CARGADOS
    /// </summary>
    public class Producto
    {
        int idProducto { get; set; }
        String nombre { get; set; }
        double precio { get; set; }
        int estado { get; set; } //en la BD es booleano, asi que solo poner 0 o 1
    
        public Producto(int idProducto, String nombre, double precio, int estado)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.estado = estado;
        }

        public Producto(String nombre, double precio, int estado)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.estado = estado;
        }
    }
}