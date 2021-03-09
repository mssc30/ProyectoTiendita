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
        public String clave { get; set; }

        public Pedido(int numPedido, String emailCliente, double precioTotal, String clave)
        {
            this.numPedido = numPedido;
            this.emailCliente = emailCliente;
            this.precioTotal = precioTotal;
            this.clave = clave;
        }
    }
}