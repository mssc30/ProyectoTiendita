using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTiendita.POJOS
{
    /// <summary>
    /// POJO QUE REPRESENTA UN PEDIDO CON SUS ATRIBUTOS Y CONSTRUCTOR
    /// </summary>
    public class Pedido
    {
        int numPedido { get; set; }
        String emailCliente { get; set; }
        double precioTotal { get; set; }
        int estadoPedido { get; set; } //mandar 0 o 1
        String fecha { get; set; }
        String hora { get; set; }

        public Pedido(int numPedido, String emailCliente, double precioTotal, int estadoPedido, String fecha, String hora)
        {
            this.numPedido = numPedido;
            this.emailCliente = emailCliente;
            this.precioTotal = precioTotal;
            this.estadoPedido = estadoPedido;
            this.fecha = fecha;
            this.hora = hora;
        }
    }
}