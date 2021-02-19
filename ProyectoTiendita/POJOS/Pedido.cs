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
        public int numPedido{get;set; }
        public String emailCliente { get; set; }
        public double precioTotal { get; set; }
        public int estadoPedido { get; set; } //mandar 0 o 1
        public String fecha { get; set; }
        public String hora { get; set; }

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