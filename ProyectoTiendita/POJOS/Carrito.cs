using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTiendita.POJOS
{
    public class Carrito
    {
        public String idCliente { get; set; }
        public int idProducto { get; set; }
        public String nombreProducto { get; set; }
        public int cantidad { get; set; }
        public double subtotal { get; set; }

        public Carrito(String idCliente, int idProducto, String nombreProducto, int cantidad, double subtotal) {
            this.idCliente = idCliente;
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }

        public Carrito() { }
    }
}