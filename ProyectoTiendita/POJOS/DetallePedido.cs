using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTiendita.POJOS
{
    /// <summary>
    /// POJO QUE REPRESENTA UN DETALLE DE PEDIDO CON SUS ATRIBUTOS
    /// CUENTA CON DOS CONSTRUCTORES SOBRECARGADOS
    /// </summary>
    public class DetallePedido
    {
        int numPedido { get; set; }
        int idProducto { get; set; }
        int cantidad { get; set; }

        public DetallePedido(int numPedido, int idProducto, int cantidad)
        {
            this.numPedido = numPedido;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }

        public DetallePedido(int idProducto, int Cantidad)
        {
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }
    }
}