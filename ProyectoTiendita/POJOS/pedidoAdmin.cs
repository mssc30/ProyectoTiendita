using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTiendita.POJOS
{
    public class pedidoAdmin
    {
        public String ID { get; set; }
        public String ID_CLIENTE { get; set; }
        public String DIRECCION { get; set; }
        public String PEDIDO { get; set; }
        public double TOTAL { get; set; }
        public String ESTADO { get; set; }
    }
}