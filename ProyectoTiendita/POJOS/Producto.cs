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
    /// 
    [Serializable]
    public class Producto
    {
        public int idProducto { get; set; }
        public String nombre { get; set; }
        public double precio { get; set; }
        public int estado { get; set; } //en la BD es booleano, asi que solo poner 0 o 1
        public String foto { get; set; }
    
        public Producto(int idProducto, String nombre, double precio, int estado, String foto)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.estado = estado;
            this.foto = foto;
        }

        public Producto(String nombre, double precio, int estado, String foto)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.estado = estado;
            this.foto = foto;
        }

        public Producto() { }
    }
}