using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTiendita.POJOS
{
    public class pedidoAdmin
    {
        public String ID { get; set; }
        public String idCliente { get; set; }
        public String direccion { get; set; }
        public String pedido { get; set; }
        public double total { get; set; }
    }
}